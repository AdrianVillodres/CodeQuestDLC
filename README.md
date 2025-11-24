# Chapter 1

**Test case 1: op = 1, name = Adrian**

| #Instruction | #Iteration | op | playerName | randNum | power | totalPower | condition |
|--------------|------------|----|------------|---------|-------|------------|-----------|
| 1 | - | 1 | - | - | - | - | option > 0 && option < 8 = true |
| 2 | - | 1 | Adrian | 0 | 0 | 0 | - |
| 3 | 1 | 1 | Adrian | Random(1,25)=5 | Random(1,11)=2 | 2 | Output = "Today I meditated for 5 hours! My power might increase to 2, my total power is 2" |
| 3 | 2 | 1 | Adrian | Random(1,25)=4 | Random(1,11)=6 | 8 | Output = "Today I meditated for 4 hours! My power might increase to 6, my total power is 8" |
| 3 | 3 | 1 | Adrian | Random(1,25)=6 | Random(1,11)=8 | 11 | Output = "Today I meditated for 6 hours! My power might increase to 8, my total power is 11" |
| 3 | 4 | 1 | Adrian | Random(1,25)=20 | Random(1,11)=3 | 14 | Output = "Today I meditated for 20 hours! My power might increase to 3, my total power is 14" |
| 3 | 5 | 1 | Adrian | Random(1,25)=17 | Random(1,11)=10 | 24 | Output = "Today I meditated for 17 hours! My power might increase to 10, my total power is 24" |
| 4 | - | 1 | Adrian | Random(1,25)=17 | Random(1,11)=10 | 24 | totalpower >= 20 && totalpower < 30 = true |
| 5 | - | 1 | Adrian | Random(1,25)=17 | Random(1,11)=10 | 24 | Output= "You still confuse the wand with a spoon, Zyn the bugged" |

**Test case 2: op = 11, name = Adrian**

| #Instruction | #Iteration | op | playerName | randNum | power | totalPower | condition |
|--------------|------------|----|------------|---------|-------|------------|-----------|
| 1 | - | 11 | - | - | - | - | option > 0 && option < 8 = false |
| 2 | - | 11 | Adrian | 0 | 0 | 0 | Output = "Error, must be a number between 1,7" |

**Test case 3: op = 0, name = Adrian**

| #Instruction | #Iteration | op | playerName | randNum | power | totalPower | condition |
|--------------|------------|----|------------|---------|-------|------------|-----------|
| 1 | - | 1 | - | - | - | - | option > 0 && option < 8 = false |
| 2 | - | 1 | Adrian | 0 | 0 | 0 | Output = "Exit" |

---

# Chapter 2

**Test case 1: op = 2**

| #Instruction | #Iteration | op | randNum | enemy | enemy HP | rolledNumber | Dice | condition |
|--------------|------------|----|---------|-------|----------|--------------|------|-----------|
| 1 | - | 2 | 3 | Ember Wolf | 11 | - | - | option > 0 && option < 8 = true |
| 2 | 1 | 2 | 3 | Ember Wolf | 6 | 5 | FiveDice | enemy HP <= 0 = false |
| 2 | 2 | 2 | 3 | Ember Wolf | 3 | 3 | ThreeDice | enemy HP <= 0 = false |
| 2 | 3 | 2 | 3 | Ember Wolf | 0 | 4 | FourDice | enemy HP <= 0 = true |
| 3 | - | 2 | 3 | Ember Wolf | 0 | 4 | FourDice | Output = "The Ember Wolf has been defeated!" |

---

# Chapter 3

**Test case 1: op = 3, digXAxis = 2,3,4,2,1, digYAxis = 3,4,2,1,4**

| #Instruction | #Iteration | op | digCounter | bitcoinFound | bitcoinCounter | digXAxis | digYAxis | condition |
|--------------|------------|----|------------|--------------|----------------|----------|----------|-----------|
| 1 | - | 3 | 5 | 0 | 0 | 0 | 0 | true |
| 2 | 1 | 3 | 4 | Random(5,51)=25 | 25 | 2 | 3 | true |
| 2 | 2 | 3 | 3 | Random(5,51)=17 | 42 | 3 | 4 | true |
| 2 | 3 | 3 | 2 | Random(5,51)=30 | 72 | 4 | 2 | true |
| 2 | 4 | 3 | 1 | Random(5,51)=42 | 104 | 2 | 1 | true |
| 2 | 5 | 3 | 0 | Random(5,51)=5 | 109 | 1 | 4 | false |
| 3 | - | 3 | 0 | Random(5,51)=5 | 109 | 1 | 4 | Output = "Your magic card is still integrated. It's time to defeat another dragon!" |

**Test case 2: op = 3, digXAxis = 1,3,4,2,0, digYAxis = 2,4,2,1,0**

| #Instruction | #Iteration | op | digCounter | bitcoinFound | bitcoinCounter | digXAxis | digYAxis | condition |
|--------------|------------|----|------------|--------------|----------------|----------|----------|-----------|
| 1 | - | 3 | 5 | 0 | 0 | 0 | 0 | true |
| 2 | 1 | 3 | 4 | Random(5,51)=5 | 5 | 1 | 2 | true |
| 2 | 2 | 3 | 3 | Random(5,51)=5 | 10 | 3 | 4 | true |
| 2 | 3 | 3 | 2 | Random(5,51)=10 | 20 | 4 | 2 | true |
| 2 | 4 | 3 | 1 | Random(5,51)=30 | 50 | 2 | 1 | true |
| 2 | 5 | 3 | 0 | Random(5,51)=50 | 100 | 0 | 0 | false |
| 3 | - | 3 | 0 | Random(5,51)=50 | 100 | 0 | 0 | Output = "Your magic card is still integrated. It's time to defeat another dragon!" |

**Test case 3: op = 3, digXAxis = 2,3,4,2,11,0, digYAxis = 3,4,2,1,1,4**

| #Instruction | #Iteration | op | digCounter | bitcoinFound | bitcoinCounter | digXAxis | digYAxis | condition |
|--------------|------------|----|------------|--------------|----------------|----------|----------|-----------|
| 1 | - | 3 | 5 | 0 | 0 | 0 | 0 | true |
| 2 | 1 | 3 | 4 | Random(5,51)=25 | 25 | 2 | 3 | true |
| 2 | 2 | 3 | 3 | Random(5,51)=17 | 42 | 3 | 4 | true |
| 2 | 3 | 3 | 2 | Random(5,51)=30 | 72 | 4 | 2 | true |
| 2 | 4 | 3 | 1 | Random(5,51)=42 | 104 | 2 | 1 | true |
| 2 | 4 | 3 | 1 | Random(5,51)=13 | 104 | 11 | 1 | false Output = "Error, you have to put an integer number between 0 and 4" |
| 2 | 5 | 3 | 0 | Random(5,51)=5 | 109 | 0 | 4 | false |
| 3 | - | 3 | 0 | Random(5,51)=5 | 109 | 0 | 4 | Output = "Your magic card is still integrated. It's time to defeat another dragon!" |

# Chapter 4

**Test case 1: op = 4, inventory = empty**

| #Instruction | #Iteration | op | inventory | condition |
|--------------|------------|----|-----------|-----------|
| 1 | - | 4 | null | inventory.length == 0 = true |
| 2 | - | 4 | null | Output = "Your inventory is empty" |

**Test case 2: op = 4, inventory = Iron Dagger**

| #Instruction | #Iteration | op | inventory | condition |
|--------------|------------|----|-----------|-----------|
| 1 | - | 4 | ["iron dagger"] | inventory.length == 0 = true |
| 2 | 1 | 4 | ["iron dagger"] | output = "iron dagger" |

---

# Chapter 5

**Test case 1: op = 5, bitcoinCounter = 500, itemInput = 1**

| #Instruction | #Iteration | op | itemInput | validInput | bitcoinCounter | prices[] | inventory | newInventory[] | condition |
|--------------|------------|----|-----------|------------|----------------|----------|-----------|----------------|-----------|
| 1 | - | 5 | 1 | true | 500 | prices[itemInput]=30 | null | null | validInput && itemInput >0 && itemInput <=5 = true |
| 2 | - | 5 | 1 | true | 500 | prices[itemInput]=30 | "Iron dagger" | "Iron dagger" | bitcoinCounter >= prices[itemInput] = true |
| 3 | - | 5 | 1 | true | 470 | prices[itemInput]=30 | "Iron dagger" | "Iron dagger" | Output = "You bought Iron dagger" |

**Test case 2: op = 5, bitcoinCounter = 0, itemInput = 1**

| #Instruction | #Iteration | op | itemInput | validInput | bitcoinCounter | prices[] | inventory | newInventory[] | condition |
|--------------|------------|----|-----------|------------|----------------|----------|-----------|----------------|-----------|
| 1 | - | 5 | 1 | true | 0 | prices[itemInput]=30 | null | null | validInput && itemInput >0 && itemInput <=5 = true |
| 1 | - | 5 | 1 | true | 0 | prices[itemInput]=30 | null | null | bitcoinCounter >= prices[itemInput] = false |
| 1 | - | 5 | 1 | true | 0 | prices[itemInput]=30 | null | null | Output = "You don't have enough bitcoins" |

**Test case 3: op = 5, bitcoinCounter = 0, itemInput = 15**

| #Instruction | #Iteration | op | itemInput | validInput | bitcoinCounter | prices[] | inventory | newInventory[] | condition |
|--------------|------------|----|-----------|------------|----------------|----------|-----------|----------------|-----------|
| 1 | - | 5 | 15 | false | 0 | prices[itemInput]=30 | null | null | validInput && itemInput >0 && itemInput <=5 = false Output = "Sorry, we don't have that, select an integer number between 0 and 5" |
| 2 | - | 5 | 15 | false | 0 | prices[itemInput] | null | null | - |

---

# Chapter 6

**Test case 1: op = 6, level = 2**

| #Instruction | #Iteration | op | level | condition |
|--------------|------------|----|-------|-----------|
| 1 | - | 6 | 2 | - |
| 2 | 1 | 6 | 2 | Output = "Fireball" |
| 2 | 2 | 6 | 2 | Output = "Ice ray" |
| 2 | 3 | 6 | 2 | Output = "Arcane shield" |

# Chapter 7

**Test case 1: op = 7, scrollDecode = 1**

| #Instruction | #Iteration | op | scrollDecode | firstScrollDecoded | condition |
|--------------|------------|----|--------------|--------------------|-----------|
| 1 | - | 7 | 1 | - | scrollDecode < 1 \| scrollDecode > 3 = false |
| 2 | - | 7 | 1 | "The @ sleep sinthemount ainoffire '" | Output = "The sleep sinthemount ainoffire" |

**Test case 2: op = 7, scrollDecode = 0**

| #Instruction | #Iteration | op | scrollDecode | firstScrollDecoded | condition |
|--------------|------------|----|--------------|--------------------|-----------|
| 1 | - | 7 | 0 | - | scrollDecode < 1 \| scrollDecode > 3 = true |
| 2 | - | 7 | 0 | - | Output = "Error, you must put an integer number between 1 and 3" |

**Test case 3: op = 7, scrollDecode = 15**

| #Instruction | #Iteration | op | scrollDecode | firstScrollDecoded | condition |
|--------------|------------|----|--------------|--------------------|-----------|
| 1 | - | 7 | 15 | - | scrollDecode < 1 \| scrollDecode > 3 = true |
| 2 | - | 7 | 15 | - | Output = "Error, you must put an integer number between 1 and 3" |
