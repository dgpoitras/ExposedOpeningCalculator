import numpy as np

z_area_list = [30, 40, 50, 100, 101]

y_selection = {
    0: 'y_30',
    1: 'y_40',
    2: 'y_50',
    3: 'y_100',
    4: 'y_101'
}

x_limit_list = np.array([
    0.0,
    1.2,
    1.5,
    2.0,
    4.0,
    6.0,
    8.0,
    10.0,
    12.0,
    16.0,
    20.0,
    25.0
])

y_30 = np.array([
    0,
    7,
    9,
    12,
    39,
    88,
    100,
    100,
    100,
    100,
    100,
    100
])

y_40 = np.array([
    0,
    7,
    8,
    11,
    32,
    69,
    100,
    100,
    100,
    100,
    100,
    100
])

y_50 = np.array([
    0,
    7,
    8,
    10,
    28,
    57,
    100,
    100,
    100,
    100,
    100,
    100
])

y_100 = np.array([
    0,
    7,
    8,
    9,
    18,
    34,
    56,
    84,
    100,
    100,
    100,
    100
])

y_101 = np.array([
    0,
    7,
    7,
    8,
    12,
    19,
    28,
    40,
    55,
    92,
    100,
    100
])
