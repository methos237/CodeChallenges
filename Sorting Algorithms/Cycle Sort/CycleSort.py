def cycle_sort(array):
    writes = 0

    for cycleStart in range(len(array) - 1):
        item = array[cycleStart]
        pos = cycleStart

        for i in range(cycleStart + 1, len(array)):
            if array[i] < item:
                pos += 1

        if pos == cycleStart:
            continue

        while item == array[pos]:
            pos += 1

        array[pos], item = item, array[pos]
        writes += 1

        while pos != cycleStart:
            pos = cycleStart

            for i in range(cycleStart + 1, len(array)):
                if array[i] < item:
                    pos += 1

            while item == array[pos]:
                pos += 1

            array[pos], item = item, array[pos]
            writes += 1

    return writes