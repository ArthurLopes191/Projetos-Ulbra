from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys

driver = webdriver.Chrome()

driver.get('https://www.browserstack.com/users/sign_in/')

driver.maximize_window()

driver.find_element(By.CSS_SELECTOR, ('#user_email_login')).send_keys('arthurlopesreal@gmail.com')

driver.find_element(By.CSS_SELECTOR, ('#user_password')).send_keys('Ratutui191')

driver.find_element(By.CSS_SELECTOR, ('#user_submit')).click()

driver.quit()




