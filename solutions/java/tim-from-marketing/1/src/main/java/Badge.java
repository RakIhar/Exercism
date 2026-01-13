class Badge {
//    Badge badge = new Badge();
//badge.print(734, "Ernest Johnny Payne", "Strategic Communication");
// => "[734] - Ernest Johnny Payne - STRATEGIC COMMUNICATION"

//Badge badge = new Badge();
//Badge.print(null, "Jane Johnson", "Procurement");
// => "Jane Johnson - PROCUREMENT"

//Badge badge = new Badge();
//badge.print(254, "Charlotte Hale", null);
// => "[254] - Charlotte Hale - OWNER"

//Badge badge = new Badge();
//badge.print(null, "Charlotte Hale", null);
// => "Charlotte Hale - OWNER"

    public String print(Integer id, String name, String department) {
        StringBuilder res = new StringBuilder();

        if (id != null)
            res.append("[" + id + "] - ");
        res.append(name);

        if (department != null)
            res.append(" - " + department.toUpperCase());
        else
            res.append(" - OWNER");

        return  res.toString();
    }
}
