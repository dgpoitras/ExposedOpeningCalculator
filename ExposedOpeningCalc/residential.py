import argparse
import logging
import sys
import numpy as np
import data

logger = logging.getLogger(__name__)
logging.basicConfig(level=logging.DEBUG)


class ResidentialCalc():
    """Class that will handle calculating for Residential, business and personal services,
    and low-hazard industrial occupation classification of buildings."""

    def calc_values(self, exposed_face):
        face = data.z_area_list[0]
        for v in data.z_area_list:
            if v < exposed_face:
                face = v
        logger.debug(f'initial value {face} is type {type(face)}')
        idx = data.z_area_list.index(face)
        logger.debug(f'{exposed_face} uses index {idx}')
        result = getattr(data, data.y_selection[idx])
        logger.debug(f'return data {result}')
        return result

    def calc_point(self, limit_dist, values):
        if float(limit_dist) < float(data.x_limit_list[1]):
            logger.debug(f'Small side {limit_dist} < {float(data.x_limit_list[1])}')
            return 0.00
        if float(limit_dist) > float(max(data.x_limit_list)):
            logger.debug(f'Large side {limit_dist} > {float(max(data.x_limit_list))}')
            return 100.00
        logger.debug(f'passed {limit_dist}')
        x = data.x_limit_list
        y = data.y_30
        return np.interp(limit_dist, x, y)


if __name__ == '__main__':
    parser = argparse.ArgumentParser(
        prog='residential_calc',
        description='calculates the max area from a limiting distance')
    parser.add_argument('dist_limit')
    parser.add_argument('-m', '--max_area', default=30)
    args = parser.parse_args()
    app = ResidentialCalc()
    area = app.calc_values(105)
    res = app.calc_point(args.dist_limit, args.max_area)
    logger.debug(res)
    print(f'Maximum area is {res:.2f} square meters')
