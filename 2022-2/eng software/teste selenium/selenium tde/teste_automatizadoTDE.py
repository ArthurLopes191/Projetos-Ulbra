from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys
import time

driver = webdriver.Chrome()

driver.get('https://google.com/')

driver.maximize_window()

driver.find_element(By.CSS_SELECTOR, ('.gLFyf')).send_keys("Computação ULBRA Torres")

driver.find_element(By.CSS_SELECTOR, ('.gLFyf')).send_keys(Keys.ENTER)



time.sleep(5)