using System;
using System.Collections.Generic;
using System.Linq;

public class TreeBuildingRecord
{
    public int ParentId { get; set; }
    public int RecordId { get; set; }
}

public class Tree
{
    public int Id { get; set; }
    public int ParentId { get; set; }

    public List<Tree> Children { get; set; }

    public bool IsLeaf => Children.Count == 0;
}

public static class TreeBuilder
{
    public static Tree BuildTree(IEnumerable<TreeBuildingRecord> records)
    {
        var ordered = records.OrderBy(q => q.RecordId);

        records = ordered;

        var trees = new List<Tree>();
        var previousRecordId = -1;

        foreach (var record in records)
        {
            var t = new Tree { Children = new List<Tree>(), Id = record.RecordId, ParentId = record.ParentId };
            trees.Add(t);
            Teste(previousRecordId, t);

            ++previousRecordId;

        }
        if (trees.Count != 0)
        {
            ClassificaTrees(trees);
            return trees.First(t => t.Id == 0);
        }
        throw new ArgumentException();
    }

    private static void ClassificaTrees(List<Tree> trees)
    {
        for (int i = 1; i < trees.Count; i++)
        {
            var t = trees.First(x => x.Id == i);
            var parent = trees.First(x => x.Id == t.ParentId);
            parent.Children.Add(t);
        }
    }
    private static void Teste(int previousRecordId, Tree t)
    {
        if (t.Id == 0 && (t.ParentId == 0))
        {
               return;
        }
        else
        {
            if (t.ParentId >= t.Id || t.Id != previousRecordId + 1)
            {
                throw new ArgumentException();
            }
        }

    }
}