using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragment
{
    protected int id;
    protected string name;
    protected GameObject prefab;

    public string _name
	{
		get
		{
            return name;
		}
	}

    public Fragment(int id, string name)
	{
        this.id = id;
        this.name = name;
	}

    public Fragment(string name)
    {
        this.name = name;
    }
}
