class Person:

  def __init__(self):
    self.name = ""

  #...

class Employee(Person):

  def __init__(self):
    self.name = ""
    self.manager = None

  def vacation(self):
    return 14

  def display(self):
    print("My name is {0} and I get {1} vacation days".format(self.name, self.vacation()))

class Manager(Employee):

  def vacation(self):
    return 21

# -------
# -----

e = Employee()
e.name = "Jeff"
# e.set_name("Jeff")

m = Manager()
m.name = "Cookie Monster"
e.manager = m

# p = Person()
# p.name = "Ernie"
# p.display()

m.display()
e.display()





