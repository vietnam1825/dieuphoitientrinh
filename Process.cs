using System;
using System.IO;
clas Process{
    // Private attribute
    
    string name;
    int timeRL, timeCPU, priority;
    int timeIN, timeOUT, timewait, timesave;
    int index;
    
    // Getters and setters
    public string Name{
        get{
            return name;
        }
        set{
            name = value;
        }
    }
    public int TimeRL{
        get{
            return timeRL;
        }
        set{
            timeRL = value;
        }
    }
    public int TimeCPU{
        get{
            return timeCPU;
        }
        set{
            timeCPU = value;
        }
    }
    public int Priority{
        get{
            return priority;
        }
        set{
            priority = value;
        }
    }
    public int TimeIN{
        get{
            return timeIN;
        }
        set{
            timeIN = value;
        }
    }
    public int TimeOUT{
        get{
            return timeOUT;
        }
        set{
            timeOUT = value;
        }
    }
    public int Timewait{
        get{
            return timewait;
        }
        set{
            timewait = value;
        }
    }
    public int Timesave{
        get{
            return timesave;
        }
        set{
            timesave = value;
        }
    }
    public int Index{
        get{
            return index;
        }
        set{
            index = value;
        }
    }

    // Input methods
    void input(ref)
