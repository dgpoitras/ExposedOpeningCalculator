import sys

from PyQt6.QtWidgets import QApplication, QMainWindow, QWidget
from gui import Gui


def main():
    """ExposedOpeningCalc's main function."""
    pycalcApp = QApplication([])
    pycalcWindow = Gui()
    pycalcWindow.show()
    sys.exit(pycalcApp.exec())


if __name__ == "__main__":
    main()
