import argparse
import sys
import numpy as np

class ResidentialCalc():
    """Class that will handle calcualting for Residential, business and personal services,
    and low-hazard industrial occupation classification of buildings."""

    def __init__(self):
        self.area_list = [0, 30, 40, 50, 100, 101]
        self.p30_x = np.array([
            0.0,
            1.2,
            1.5,
            2.0,
            4.0,
            6.0,
            8.0,
        ])
        self.p30_y = np.array([
            0,
            7,
            9,
            12,
            39,
            88,
            100,
        ])

    def calc_values(self, exposed_face):
        pass
    def calc_point(self, limit_dist, values):
        x = self.p30_x
        y = self.p30_y
        return np.interp(limit_dist, x, y)


if __name__ == '__main__':
    parser = argparse.ArgumentParser(
        prog='residential_calc',
        description='calculates the max area from a limiting distance')
    parser.add_argument('dist_limit')
    parser.add_argument('-m', '--max_area', default=30)
    args = parser.parse_args()
    app = ResidentialCalc()
    res = app.calc_point(args.dist_limit, args.max_area)
    print(res)
    print(f'Maximum area is {res:.2f} square meters')
