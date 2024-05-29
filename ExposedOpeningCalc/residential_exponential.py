import json
import numpy as np
import matplotlib.pyplot as plt
from sklearn.metrics import r2_score
from scipy.optimize import curve_fit


class ResidentialCalc():
    """Class that will handle calcualting for Residential, business and personal services,
    and low-hazard industrial occupation classification of buildings."""

    def __init__(self):
        self.p30_y = np.array([
            0.0,
            1.2,
            1.5,
            2.0,
            4.0,
            6.0,
            8.0,
            #10.0,
            #12.0,
            #16.0,
            #20.0,
            #25.0
        ])
        self.p30_x = np.array([
            0,
            7,
            9,
            12,
            39,
            88,
            100,
            #100,
            #100,
            #100,
            #100,
            #100
        ])
        self.p100_y = np.array([
            0.0,
            1.2,
            1.5,
            2.0,
            4.0,
            6.0,
            8.0,
            10.0,
            12.0,
            #16.0,
            #20.0,
            # 25.0
        ])
        self.p100_x = np.array([
            0,
            7,
            8,
            9,
            18,
            34,
            56,
            84,
            100,
            # 100,
            # 100,
            # 100
        ])

    def load_table(self):
        """Load the table information from file, may replace with DB later"""

        f = open("Residential_Data.json", 'r')
        data = json.load(f)
        return data

    def calc_point(self, x, y):
        popt, pcov = curve_fit(self.exponential_func, x, y, p0=[1.44, 0.35], maxfev=5000)

        a_opt, b_opt = popt

        x_fit = np.linspace(min(x), max(x), 40)
        y_fit = self.exponential_func(x_fit, a_opt, b_opt)

        y_predicted = self.exponential_func(x, a_opt, b_opt)

        r2 = r2_score(y, y_predicted)
        sse = self.calculate_sse(y, y_predicted)

        n = len(y)
        p = len(popt)
        adjusted_R_squared = 1 - (1 - r2) * (n - 1) / (n - p -1)

        result = {'x': x_fit, 'y':y_fit, 'r2':r2, 'coefficients': popt, 'sse': sse, 'adj_r2': adjusted_R_squared}

        return result

    def exponential_func(self, x, a, b):
        return a * np.exp(b * x)

    def calculate_sse(self, y_actual, y_predicted):
        # Convert the input lists to NumPy arrays for vectorized operations
        y_actual = np.array(y_actual)
        y_predicted = np.array(y_predicted)

        # Calculate squared errors and sum them up
        squared_errors = (y_actual - y_predicted) ** 2
        sse = np.sum(squared_errors)

        return sse

    def show_plot(self, data):
        plt.scatter(self.p100_x, self.p100_y)
        plt.plot(data['x'], data['y'])
        plt.xlabel('x')
        plt.ylabel('y')
        plt.legend(['Data', 'Exponential fit'])
        plt.show()


if __name__ == '__main__':
    app = ResidentialCalc()
    #res_data = a.load_table()
    #print(res_data)
    # res = app.calc_point(app.p30_x, app.p30_y)
    res = app.calc_point(app.p100_x, app.p100_y)

    print(res)
    app.show_plot(res)
