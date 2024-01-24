from selenium import webdriver
from selenium.webdriver.common.by import By


#Iniciar o navegador
driver = webdriver.Chrome()
#Acessar URL ddo Python

driver.get('https://www.python.org/')
#digitar o texto "Python" no input
driver.find_element(By.CSS_SELECTOR, ('#id-search-field')).send_keys("Python")
#Clicar no botão de pesquisar
driver.find_element(By.CSS_SELECTOR, ('#submit')).click()
#Encerrar o browser
driver.quit()