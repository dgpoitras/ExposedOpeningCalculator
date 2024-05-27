import sys

from PyQt6.QtWidgets import QMainWindow, QLabel, QWidget

WINDOW_SIZE = 235

class Gui(QMainWindow):
    """ExposedOpeningCalc's main window (GUI or view)."""

    def __init__(self):
        super().__init__()
        self.setWindowTitle("Exposed Opening Calculator")
        self.setFixedSize(WINDOW_SIZE, WINDOW_SIZE)
        centralWidget = QWidget(self)
        self.setCentralWidget(centralWidget)
