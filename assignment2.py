def main():
    f_name = input("First Name: ")
    l_name = input("Last Name: ")
    phone = input("Phone Number: ")
    num_panels = input("Number of Panels: ")
    deposit = input("Deposit Amount: ")
    express = input("Express Installation? (Y/N): ")

    # convert necessary values to actual numbers
    act_panel = int(num_panels)
    act_dep = float(deposit)

    # convert boolean
    act_express = convert_to_bool(express)

    show_charges(f_name, l_name, act_panel, act_dep, act_express)


def convert_to_bool(x):
    y = "y";
    if x.casefold() == y.casefold():
        return True
    else:
        return False


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
    print("Balance Due: " + "${:,.2f}".format(calc_amount_due(num, express, deposit)))


main()
