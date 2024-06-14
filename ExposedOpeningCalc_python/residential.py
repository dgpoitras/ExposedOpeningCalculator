import argparse
import logging
import sys
import numpy as np
import data

logger = logging.getLogger(__name__)
logging.basicConfig(level=logging.INFO)


class ResidentialCalc():
    """Class that will handle calculating for Residential, business and personal services,
    and low-hazard industrial occupation classification of buildings."""

    def get_values(self, exposed_face):
        face = data.z_area_list[0]
        for v in data.z_area_list:
            if v <= exposed_face:
                face = v
        logger.debug(f'initial value {face} is type {type(face)}')

        idx = data.z_area_list.index(face)
        logger.debug(f'{exposed_face} uses index {idx}')

        if exposed_face != face:
            logger.debug(f'these are the different param {exposed_face} and closest face {face}')
            return self.calc_new_values(exposed_face, idx)

        return getattr(data, data.y_selection[idx])

    def calc_new_values(self, value, idx):
        # get the % diff between index of z and the next z value
        min_z = data.z_area_list[idx]
        max_z = data.z_area_list[idx+1]

        z_margin = max_z - min_z
        fix = value - min_z
        real_margin = fix / z_margin
        logger.debug(f'\ndata_margin: {z_margin}\nfix: {fix}\nreal Margin: {real_margin}')

        # use the z% to calculate the new Y between each gap.
        new_y = value
        min_y = getattr(data, data.y_selection[idx])
        max_y = getattr(data, data.y_selection[idx + 1])
        logger.debug(f'min_y: {min_y}, max_y{max_y}')
        new_x_list = []
        for i in range(len(data.x_limit_list)):
            min_x = min_y[i]
            max_x = max_y[i]
            x_margin = min_x - max_x
            new_x = min_x - x_margin * real_margin
            logger.debug(f'min_x: {min_x}, max_x:{max_x}, x_margin: {x_margin}, new_x: {new_x}')
            new_x_list.append(new_x)

        logger.debug(f'new x values for new y {new_y} is {new_x_list}')
        return np.array(new_x_list)

    def calc_point(self, limit_dist, values):
        if limit_dist < data.x_limit_list[1]:
            logger.debug(f'Small side {limit_dist} < {data.x_limit_list[1]}')
            return 0.00
        if limit_dist > float(max(data.x_limit_list)):
            logger.debug(f'Large side {limit_dist} > {max(data.x_limit_list)}')
            return 100.00
        logger.debug(f'passed {limit_dist}')
        x = data.x_limit_list
        y = values
        return np.interp(limit_dist, x, y)


if __name__ == '__main__':
    parser = argparse.ArgumentParser(
        prog='residential_calc',
        description='calculates the max area from a limiting distance')
    parser.add_argument('dist_limit')
    parser.add_argument('-m', '--max_area', default=30)
    args = parser.parse_args()
    app = ResidentialCalc()
    area = app.get_values(int(args.max_area))
    res = app.calc_point(float(args.dist_limit), area)
    logger.debug(res)
    print(f'Maximum percentage of unprotected openings is {res:.2f} square meters')
