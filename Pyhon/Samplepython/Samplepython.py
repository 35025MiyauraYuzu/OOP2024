# 1 2 3 4 5 6 7 8 9 10


# for n in range(1,11):
#     print(n," ", end="")

# a =5
# b=3
# a,b=b,a
# print(a,b)

# a =[1,2]
# b =[3,4]
# s=0;
# for n,m in enumerate(a+b):
#         s= s + n * m
# print(s)
        

# for i in zip(a,b):
#     print(i)    
#     #[1,3]
#     #[2,4]  
#     
# for i in enumerate(a):
#     print(i)
#     #[0,1]
#     #[1,2]

# from textwrap import indent


# cities = ['Tokyp','Paris','London','Beijing','New York']

# for index,cit 

# numbers = [1,2,3,4,5,6,7,8,9,10]
# for number in numbers:00
#    if number % 2 == 0:
#     print(number)
#    else:
#      print('奇数')


# print('数値を入力') #100以上で合格
# nums = input()
# print(nums)
# if int(nums)>=100:
#     print('合格')
# else:
#     print('不合格')


# from os import name


# menber = {'name':'坂本龍馬','age':28,'gender':'male'}
# print(menber['name'])

# from sys import base_exec_prefix


# def func():
#     a = 1
#     b = 2
#     c = a + b
#     print(c)

# func()

from dataclasses import dataclass


@dataclass#クラスの定義
class Item:
    kind:str
    price:int
   
def tax_included_proce(item):
    if item.kind == "food":
        return round( item.price * 1.08)
    else:
        return round (item.price * 1.1)
    
def total_amount(items):
    amounts= [tax_included_proce(item) for item in items] #内包表記
    return sum(amounts)
    
items = [Item("food",200),
         Item("book",1000),
         Item("food",100),] 
print(total_amount(items))