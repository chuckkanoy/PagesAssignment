import re

def main():
    f_name = check_name(input("First Name: "))
    l_name = check_name(input("Last Name: "))
    phone = check_phone(input("Phone Number: "))
    num_panels = check_num(input("Number of Panels: "))
    act_panel = int(num_panels)

    deposit = check_money(input("Deposit Amount: "))
    act_dep = float(deposit)

    express = input("Express Installation? (Y/N): ")
    # convert boolean
    act_express = convert_to_bool(express)

    show_charges(f_name, l_name, act_panel, act_dep, act_express)


def convert_to_bool(x):
    y = "y";
    n = "n";
    while x not in [y, n]:
        print("Invalid Input")
        new_x = input("Express Installation? (Y/N): ")
        return convert_to_bool(new_x);
    if x.casefold() == y.casefold():
        return True
    elif x.casefold() == n.casefold():
        return False


def check_name(x):
    if not x.isalpha():
        print("Invalid Input")
        new_x = input("Name: ")
        return check_name(new_x)
    return x


def check_phone(x):
    r = re.compile(r'(\d{3}[-\.\s]\d{3}[-\.\s]\d{4}|\(\d{3}\)\s*\d{3}[-\.\s]\d{4}|\d{3}[-\.\s]\d{4})')

    if not re.search(r, x):
        print("Invalid Input")
        new_x = input("Phone Number: ")
        return check_phone(new_x)
    return x


def check_num(x):
    r = re.compile(r'^[-+]?[0-9]+$')

    if not re.search(r, x):
        print("Invalid Input")
        new_x = input("Number of panels: ")
        return check_num(new_x)
    else:
        temp = int(x)
        if not temp <= 1000 and temp > 0:
            print("Invalid Input")
            new_x = input("Number of panels: ")
            return check_num(new_x)
    return x


def check_money(x):
    r = re.compile(r'^[0-9]*(\.[0-9]{1,2})?$')

    if not re.search(r, x):
        print("Invalid Input")
        new_x = input("Deposit Amount: ")
        return check_money(new_x)
    return x


def calc_charge(num):
    if num > 2:
        return (num - 2) * 300
    else:
        return 0


def calc_total(num, express):
    cost = 2000 + calc_charge(num)

    if express:
        cost *= 1.05

    return cost


def calc_amount_due(num, express, deposit):
    return calc_total(num, express) - deposit


def show_charges(fname, lname, num, deposit, express):
    print("")
    print("Hello, " + fname + " " + lname + ".")
    print("Base Charge for 2 Panels: " + "${:,.2f}".format(2000))
    print("Additional Panels: " + "${:,.2f}".format(calc_charge(num)))
    print("Total cost: " + "${:,.2f}".format(calc_total(num, express)))
    print("Deposit Amount: " + "${:,.2f}".format(deposit))
    if deposit <= calc_amount_due(num, express, deposit):
        print("Balance Due: " + "${:,.2f}".format(calc_amount_due(num, express, deposit)))
    else:
        print("Refund: " + "${:,.2f}".format(calc_amount_due(num, express, -deposit)))


main()
