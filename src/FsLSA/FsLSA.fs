
module LSA

// type Functor = Functor with
//     static member inline (?<-) (Functor, f, x) = Seq.map f x
//     static member inline (?<-) (Functor, f, x) = List.map f x
//     static member inline (?<-) (Functor, f, x) = Array.map f x
//     // works also for external types
//     static member inline (?<-) (Functor, f, x:int) = f x
// let inline map f x = ((?<-) Functor) f x

// auto-generated from here

type AllPairs = AllPairs with
    static member inline (?<-) (AllPairs, x1, x2) = Seq.allPairs x1 x2
    static member inline (?<-) (AllPairs, x1, x2) = List.allPairs x1 x2
    static member inline (?<-) (AllPairs, x1, x2) = Array.allPairs x1 x2
let inline allPairs x1 x2 = ((?<-) AllPairs) x1 x2


type Append = Append with
    static member inline (?<-) (Append, x1, x2) = Seq.append x1 x2
    static member inline (?<-) (Append, x1, x2) = List.append x1 x2
    static member inline (?<-) (Append, x1, x2) = Array.append x1 x2
let inline append x1 x2 = ((?<-) Append) x1 x2


type Average = Average with
    static member inline (?<-) (Average, x) = Seq.average x
    static member inline (?<-) (Average, x) = List.average x
    static member inline (?<-) (Average, x) = Array.average x
let inline average x = ((?<-) Average) x


type AverageBy = AverageBy with
    static member inline (?<-) (AverageBy, projection, x) = Seq.averageBy projection x
    static member inline (?<-) (AverageBy, projection, x) = List.averageBy projection x
    static member inline (?<-) (AverageBy, projection, x) = Array.averageBy projection x
let inline averageBy projection x = ((?<-) AverageBy) projection x


type Choose = Choose with
    static member inline (?<-) (Choose, chooser, x) = Seq.choose chooser x
    static member inline (?<-) (Choose, chooser, x) = List.choose chooser x
    static member inline (?<-) (Choose, chooser, x) = Array.choose chooser x
let inline choose chooser x = ((?<-) Choose) chooser x


type ChunkBySize = ChunkBySize with
    static member inline (?<-) (ChunkBySize, chunkSize, x) = Seq.chunkBySize chunkSize x
    static member inline (?<-) (ChunkBySize, chunkSize, x) = List.chunkBySize chunkSize x
    static member inline (?<-) (ChunkBySize, chunkSize, x) = Array.chunkBySize chunkSize x
let inline chunkBySize chunkSize x = ((?<-) ChunkBySize) chunkSize x


type Collect = Collect with
    static member inline (?<-) (Collect, mapping, x) = Seq.collect mapping x
    static member inline (?<-) (Collect, mapping, x) = List.collect mapping x
    static member inline (?<-) (Collect, mapping, x) = Array.collect mapping x
let inline collect mapping x = ((?<-) Collect) mapping x


type CompareWith = CompareWith with
    static member inline (?<-) (CompareWith, comparer, x1, x2) = Seq.compareWith comparer x1 x2
    static member inline (?<-) (CompareWith, comparer, x1, x2) = List.compareWith comparer x1 x2
    static member inline (?<-) (CompareWith, comparer, x1, x2) = Array.compareWith comparer x1 x2
let inline compareWith comparer x1 x2 = ((?<-) CompareWith) comparer x1 x2


type Concat = Concat with
    static member inline (?<-) (Concat, xs) = Seq.concat xs
    static member inline (?<-) (Concat, xs) = List.concat xs
    static member inline (?<-) (Concat, xs) = Array.concat xs
let inline concat xs = ((?<-) Concat) xs


type CountBy = CountBy with
    static member inline (?<-) (CountBy, projection, x) = Seq.countBy projection x
    static member inline (?<-) (CountBy, projection, x) = List.countBy projection x
    static member inline (?<-) (CountBy, projection, x) = Array.countBy projection x
let inline countBy projection x = ((?<-) CountBy) projection x


type Distinct = Distinct with
    static member inline (?<-) (Distinct, x) = Seq.distinct x
    static member inline (?<-) (Distinct, x) = List.distinct x
    static member inline (?<-) (Distinct, x) = Array.distinct x
let inline distinct x = ((?<-) Distinct) x


type DistinctBy = DistinctBy with
    static member inline (?<-) (DistinctBy, projection, x) = Seq.distinctBy projection x
    static member inline (?<-) (DistinctBy, projection, x) = List.distinctBy projection x
    static member inline (?<-) (DistinctBy, projection, x) = Array.distinctBy projection x
let inline distinctBy projection x = ((?<-) DistinctBy) projection x


type ExactlyOne = ExactlyOne with
    static member inline (?<-) (ExactlyOne, x) = Seq.exactlyOne x
    static member inline (?<-) (ExactlyOne, x) = List.exactlyOne x
    static member inline (?<-) (ExactlyOne, x) = Array.exactlyOne x
let inline exactlyOne x = ((?<-) ExactlyOne) x


type Except = Except with
    static member inline (?<-) (Except, itemsToExclude, x) = Seq.except itemsToExclude x
    static member inline (?<-) (Except, itemsToExclude, x) = List.except itemsToExclude x
    static member inline (?<-) (Except, itemsToExclude, x) = Array.except itemsToExclude x
let inline except itemsToExclude x = ((?<-) Except) itemsToExclude x


type Exists = Exists with
    static member inline (?<-) (Exists, predicate, x) = Seq.exists predicate x
    static member inline (?<-) (Exists, predicate, x) = List.exists predicate x
    static member inline (?<-) (Exists, predicate, x) = Array.exists predicate x
let inline exists predicate x = ((?<-) Exists) predicate x


type Exists2 = Exists2 with
    static member inline (?<-) (Exists2, predicate, x1, x2) = Seq.exists2 predicate x1 x2
    static member inline (?<-) (Exists2, predicate, x1, x2) = List.exists2 predicate x1 x2
    static member inline (?<-) (Exists2, predicate, x1, x2) = Array.exists2 predicate x1 x2
let inline exists2 predicate x1 x2 = ((?<-) Exists2) predicate x1 x2


type Filter = Filter with
    static member inline (?<-) (Filter, predicate, x) = Seq.filter predicate x
    static member inline (?<-) (Filter, predicate, x) = List.filter predicate x
    static member inline (?<-) (Filter, predicate, x) = Array.filter predicate x
let inline filter predicate x = ((?<-) Filter) predicate x


type Find = Find with
    static member inline (?<-) (Find, predicate, x) = Seq.find predicate x
    static member inline (?<-) (Find, predicate, x) = List.find predicate x
    static member inline (?<-) (Find, predicate, x) = Array.find predicate x
let inline find predicate x = ((?<-) Find) predicate x


type FindBack = FindBack with
    static member inline (?<-) (FindBack, predicate, x) = Seq.findBack predicate x
    static member inline (?<-) (FindBack, predicate, x) = List.findBack predicate x
    static member inline (?<-) (FindBack, predicate, x) = Array.findBack predicate x
let inline findBack predicate x = ((?<-) FindBack) predicate x


type FindIndex = FindIndex with
    static member inline (?<-) (FindIndex, predicate, x) = Seq.findIndex predicate x
    static member inline (?<-) (FindIndex, predicate, x) = List.findIndex predicate x
    static member inline (?<-) (FindIndex, predicate, x) = Array.findIndex predicate x
let inline findIndex predicate x = ((?<-) FindIndex) predicate x


type FindIndexBack = FindIndexBack with
    static member inline (?<-) (FindIndexBack, predicate, x) = Seq.findIndexBack predicate x
    static member inline (?<-) (FindIndexBack, predicate, x) = List.findIndexBack predicate x
    static member inline (?<-) (FindIndexBack, predicate, x) = Array.findIndexBack predicate x
let inline findIndexBack predicate x = ((?<-) FindIndexBack) predicate x


type Fold = Fold with
    static member inline (?<-) (Fold, folder, state, x) = Seq.fold folder state x
    static member inline (?<-) (Fold, folder, state, x) = List.fold folder state x
    static member inline (?<-) (Fold, folder, state, x) = Array.fold folder state x
let inline fold folder state x = ((?<-) Fold) folder state x


type Fold2 = Fold2 with
    static member inline (?<-) (Fold2, folder, state, x1, x2) = Seq.fold2 folder state x1 x2
    static member inline (?<-) (Fold2, folder, state, x1, x2) = List.fold2 folder state x1 x2
    static member inline (?<-) (Fold2, folder, state, x1, x2) = Array.fold2 folder state x1 x2
let inline fold2 folder state x1 x2 = ((?<-) Fold2) folder state x1 x2


type FoldBack = FoldBack with
    static member inline (?<-) (FoldBack, folder, x, state) = Seq.foldBack folder x state
    static member inline (?<-) (FoldBack, folder, x, state) = List.foldBack folder x state
    static member inline (?<-) (FoldBack, folder, x, state) = Array.foldBack folder x state
let inline foldBack folder x state = ((?<-) FoldBack) folder x state


type FoldBack2 = FoldBack2 with
    static member inline (?<-) (FoldBack2, folder, x1, x2, state) = Seq.foldBack2 folder x1 x2 state
    static member inline (?<-) (FoldBack2, folder, x1, x2, state) = List.foldBack2 folder x1 x2 state
    static member inline (?<-) (FoldBack2, folder, x1, x2, state) = Array.foldBack2 folder x1 x2 state
let inline foldBack2 folder x1 x2 state = ((?<-) FoldBack2) folder x1 x2 state


type ForAll = ForAll with
    static member inline (?<-) (ForAll, predicate, x) = Seq.forall predicate x
    static member inline (?<-) (ForAll, predicate, x) = List.forall predicate x
    static member inline (?<-) (ForAll, predicate, x) = Array.forall predicate x
let inline forall predicate x = ((?<-) ForAll) predicate x


type ForAll2 = ForAll2 with
    static member inline (?<-) (ForAll2, predicate, x1, x2) = Seq.forall2 predicate x1 x2
    static member inline (?<-) (ForAll2, predicate, x1, x2) = List.forall2 predicate x1 x2
    static member inline (?<-) (ForAll2, predicate, x1, x2) = Array.forall2 predicate x1 x2
let inline forall2 predicate x1 x2 = ((?<-) ForAll2) predicate x1 x2


type GroupBy = GroupBy with
    static member inline (?<-) (GroupBy, projection, x) = Seq.groupBy projection x
    static member inline (?<-) (GroupBy, projection, x) = List.groupBy projection x
    static member inline (?<-) (GroupBy, projection, x) = Array.groupBy projection x
let inline groupBy projection x = ((?<-) GroupBy) projection x


type Head = Head with
    static member inline (?<-) (Head, x) = Seq.head x
    static member inline (?<-) (Head, x) = List.head x
    static member inline (?<-) (Head, x) = Array.head x
let inline head x = ((?<-) Head) x


type Indexed = Indexed with
    static member inline (?<-) (Indexed, x) = Seq.indexed x
    static member inline (?<-) (Indexed, x) = List.indexed x
    static member inline (?<-) (Indexed, x) = Array.indexed x
let inline indexed x = ((?<-) Indexed) x


type IsEmpty = IsEmpty with
    static member inline (?<-) (IsEmpty, x) = Seq.isEmpty x
    static member inline (?<-) (IsEmpty, x) = List.isEmpty x
    static member inline (?<-) (IsEmpty, x) = Array.isEmpty x
let inline isEmpty x = ((?<-) IsEmpty) x


type Item = Item with
    static member inline (?<-) (Item, index, x) = Seq.item index x
    static member inline (?<-) (Item, index, x) = List.item index x
    static member inline (?<-) (Item, index, x) = Array.item index x
let inline item index x = ((?<-) Item) index x


type Iterate = Iterate with
    static member inline (?<-) (Iterate, action, x) = Seq.iter action x
    static member inline (?<-) (Iterate, action, x) = List.iter action x
    static member inline (?<-) (Iterate, action, x) = Array.iter action x
let inline iter action x = ((?<-) Iterate) action x


type Iterate2 = Iterate2 with
    static member inline (?<-) (Iterate2, action, x1, x2) = Seq.iter2 action x1 x2
    static member inline (?<-) (Iterate2, action, x1, x2) = List.iter2 action x1 x2
    static member inline (?<-) (Iterate2, action, x1, x2) = Array.iter2 action x1 x2
let inline iter2 action x1 x2 = ((?<-) Iterate2) action x1 x2


type IterateIndexed = IterateIndexed with
    static member inline (?<-) (IterateIndexed, action, x) = Seq.iteri action x
    static member inline (?<-) (IterateIndexed, action, x) = List.iteri action x
    static member inline (?<-) (IterateIndexed, action, x) = Array.iteri action x
let inline iterIndexed action x = ((?<-) IterateIndexed) action x


type IterateIndexed2 = IterateIndexed2 with
    static member inline (?<-) (IterateIndexed2, action, x1, x2) = Seq.iteri2 action x1 x2
    static member inline (?<-) (IterateIndexed2, action, x1, x2) = List.iteri2 action x1 x2
    static member inline (?<-) (IterateIndexed2, action, x1, x2) = Array.iteri2 action x1 x2
let inline iteri2 action x1 x2 = ((?<-) IterateIndexed2) action x1 x2


type Last = Last with
    static member inline (?<-) (Last, x) = Seq.last x
    static member inline (?<-) (Last, x) = List.last x
    static member inline (?<-) (Last, x) = Array.last x
let inline last x = ((?<-) Last) x


type Length = Length with
    static member inline (?<-) (Length, x) = Seq.length x
    static member inline (?<-) (Length, x) = List.length x
    static member inline (?<-) (Length, x) = Array.length x
let inline length x = ((?<-) Length) x


type Map = Map with
    static member inline (?<-) (Map, mapping, x) = Seq.map mapping x
    static member inline (?<-) (Map, mapping, x) = List.map mapping x
    static member inline (?<-) (Map, mapping, x) = Array.map mapping x
let inline map mapping x = ((?<-) Map) mapping x


type Map2 = Map2 with
    static member inline (?<-) (Map2, mapping, x1, x2) = Seq.map2 mapping x1 x2
    static member inline (?<-) (Map2, mapping, x1, x2) = List.map2 mapping x1 x2
    static member inline (?<-) (Map2, mapping, x1, x2) = Array.map2 mapping x1 x2
let inline map2 mapping x1 x2 = ((?<-) Map2) mapping x1 x2


type Map3 = Map3 with
    static member inline (?<-) (Map3, mapping, x1, x2, x3) = Seq.map3 mapping x1 x2 x3
    static member inline (?<-) (Map3, mapping, x1, x2, x3) = List.map3 mapping x1 x2 x3
    static member inline (?<-) (Map3, mapping, x1, x2, x3) = Array.map3 mapping x1 x2 x3
let inline map3 mapping x1 x2 x3 = ((?<-) Map3) mapping x1 x2 x3


type MapFold = MapFold with
    static member inline (?<-) (MapFold, mapping, state, x) = Seq.mapFold mapping state x
    static member inline (?<-) (MapFold, mapping, state, x) = List.mapFold mapping state x
    static member inline (?<-) (MapFold, mapping, state, x) = Array.mapFold mapping state x
let inline mapFold mapping state x = ((?<-) MapFold) mapping state x


type MapFoldBack = MapFoldBack with
    static member inline (?<-) (MapFoldBack, mapping, x, state) = Seq.mapFoldBack mapping x state
    static member inline (?<-) (MapFoldBack, mapping, x, state) = List.mapFoldBack mapping x state
    static member inline (?<-) (MapFoldBack, mapping, x, state) = Array.mapFoldBack mapping x state
let inline mapFoldBack mapping x state = ((?<-) MapFoldBack) mapping x state


// type MapIndexed = MapIndexed with
//     static member inline (?<-) (MapIndexed, mapping, x) = Seq.mapIndexed mapping x
//     static member inline (?<-) (MapIndexed, mapping, x) = List.mapIndexed mapping x
//     static member inline (?<-) (MapIndexed, mapping, x) = Array.mapIndexed mapping x
// let inline mapIndexed mapping x = ((?<-) MapIndexed) mapping x


// type MapIndexed2 = MapIndexed2 with
//     static member inline (?<-) (MapIndexed2, mapping, x1, x2) = Seq.mapIndexed2 mapping x1 x2
//     static member inline (?<-) (MapIndexed2, mapping, x1, x2) = List.mapIndexed2 mapping x1 x2
//     static member inline (?<-) (MapIndexed2, mapping, x1, x2) = Array.mapIndexed2 mapping x1 x2
// let inline mapIndexed2 mapping x1 x2 = ((?<-) MapIndexed2) mapping x1 x2


type Max = Max with
    static member inline (?<-) (Max, x) = Seq.max x
    static member inline (?<-) (Max, x) = List.max x
    static member inline (?<-) (Max, x) = Array.max x
let inline max x = ((?<-) Max) x


type MaxBy = MaxBy with
    static member inline (?<-) (MaxBy, projection, x) = Seq.maxBy projection x
    static member inline (?<-) (MaxBy, projection, x) = List.maxBy projection x
    static member inline (?<-) (MaxBy, projection, x) = Array.maxBy projection x
let inline maxBy projection x = ((?<-) MaxBy) projection x


type Min = Min with
    static member inline (?<-) (Min, x) = Seq.min x
    static member inline (?<-) (Min, x) = List.min x
    static member inline (?<-) (Min, x) = Array.min x
let inline min x = ((?<-) Min) x


type MinBy = MinBy with
    static member inline (?<-) (MinBy, projection, x) = Seq.minBy projection x
    static member inline (?<-) (MinBy, projection, x) = List.minBy projection x
    static member inline (?<-) (MinBy, projection, x) = Array.minBy projection x
let inline minBy projection x = ((?<-) MinBy) projection x


type Pairwise = Pairwise with
    static member inline (?<-) (Pairwise, x) = Seq.pairwise x
    static member inline (?<-) (Pairwise, x) = List.pairwise x
    static member inline (?<-) (Pairwise, x) = Array.pairwise x
let inline pairwise x = ((?<-) Pairwise) x


type Permute = Permute with
    static member inline (?<-) (Permute, indexMap, x) = Seq.permute indexMap x
    static member inline (?<-) (Permute, indexMap, x) = List.permute indexMap x
    static member inline (?<-) (Permute, indexMap, x) = Array.permute indexMap x
let inline permute indexMap x = ((?<-) Permute) indexMap x


type Pick = Pick with
    static member inline (?<-) (Pick, chooser, x) = Seq.pick chooser x
    static member inline (?<-) (Pick, chooser, x) = List.pick chooser x
    static member inline (?<-) (Pick, chooser, x) = Array.pick chooser x
let inline pick chooser x = ((?<-) Pick) chooser x


type Reduce = Reduce with
    static member inline (?<-) (Reduce, reduction, x) = Seq.reduce reduction x
    static member inline (?<-) (Reduce, reduction, x) = List.reduce reduction x
    static member inline (?<-) (Reduce, reduction, x) = Array.reduce reduction x
let inline reduce reduction x = ((?<-) Reduce) reduction x


type ReduceBack = ReduceBack with
    static member inline (?<-) (ReduceBack, reduction, x) = Seq.reduceBack reduction x
    static member inline (?<-) (ReduceBack, reduction, x) = List.reduceBack reduction x
    static member inline (?<-) (ReduceBack, reduction, x) = Array.reduceBack reduction x
let inline reduceBack reduction x = ((?<-) ReduceBack) reduction x


// type Replicate = Replicate with
//     static member inline (?<-) (Replicate, count, initial) = Seq.replicate count initial
//     static member inline (?<-) (Replicate, count, initial) = List.replicate count initial
//     static member inline (?<-) (Replicate, count, initial) = Array.replicate count initial
// let inline replicate count initial = ((?<-) Replicate) count initial


// type Reverse = Reverse with
//     static member inline (?<-) (Reverse, x) = Seq.reverse x
//     static member inline (?<-) (Reverse, x) = List.reverse x
//     static member inline (?<-) (Reverse, x) = Array.reverse x
// let inline reverse x = ((?<-) Reverse) x


type Scan = Scan with
    static member inline (?<-) (Scan, folder, state, x) = Seq.scan folder state x
    static member inline (?<-) (Scan, folder, state, x) = List.scan folder state x
    static member inline (?<-) (Scan, folder, state, x) = Array.scan folder state x
let inline scan folder state x = ((?<-) Scan) folder state x


type ScanBack = ScanBack with
    static member inline (?<-) (ScanBack, folder, x, state) = Seq.scanBack folder x state
    static member inline (?<-) (ScanBack, folder, x, state) = List.scanBack folder x state
    static member inline (?<-) (ScanBack, folder, x, state) = Array.scanBack folder x state
let inline scanBack folder x state = ((?<-) ScanBack) folder x state


// type Singleton = Singleton with
//     static member inline (?<-) (Singleton, value) = Seq.singleton value
//     static member inline (?<-) (Singleton, value) = List.singleton value
//     static member inline (?<-) (Singleton, value) = Array.singleton value
// let inline singleton value = ((?<-) Singleton) value


type Skip = Skip with
    static member inline (?<-) (Skip, count, x) = Seq.skip count x
    static member inline (?<-) (Skip, count, x) = List.skip count x
    static member inline (?<-) (Skip, count, x) = Array.skip count x
let inline skip count x = ((?<-) Skip) count x


type SkipWhile = SkipWhile with
    static member inline (?<-) (SkipWhile, predicate, x) = Seq.skipWhile predicate x
    static member inline (?<-) (SkipWhile, predicate, x) = List.skipWhile predicate x
    static member inline (?<-) (SkipWhile, predicate, x) = Array.skipWhile predicate x
let inline skipWhile predicate x = ((?<-) SkipWhile) predicate x


type Sort = Sort with
    static member inline (?<-) (Sort, x) = Seq.sort x
    static member inline (?<-) (Sort, x) = List.sort x
    static member inline (?<-) (Sort, x) = Array.sort x
let inline sort x = ((?<-) Sort) x


type SortBy = SortBy with
    static member inline (?<-) (SortBy, projection, x) = Seq.sortBy projection x
    static member inline (?<-) (SortBy, projection, x) = List.sortBy projection x
    static member inline (?<-) (SortBy, projection, x) = Array.sortBy projection x
let inline sortBy projection x = ((?<-) SortBy) projection x


type SortByDescending = SortByDescending with
    static member inline (?<-) (SortByDescending, projection, x) = Seq.sortByDescending projection x
    static member inline (?<-) (SortByDescending, projection, x) = List.sortByDescending projection x
    static member inline (?<-) (SortByDescending, projection, x) = Array.sortByDescending projection x
let inline sortByDescending projection x = ((?<-) SortByDescending) projection x


type SortDescending = SortDescending with
    static member inline (?<-) (SortDescending, x) = Seq.sortDescending x
    static member inline (?<-) (SortDescending, x) = List.sortDescending x
    static member inline (?<-) (SortDescending, x) = Array.sortDescending x
let inline sortDescending x = ((?<-) SortDescending) x


type SortWith = SortWith with
    static member inline (?<-) (SortWith, comparer, x) = Seq.sortWith comparer x
    static member inline (?<-) (SortWith, comparer, x) = List.sortWith comparer x
    static member inline (?<-) (SortWith, comparer, x) = Array.sortWith comparer x
let inline sortWith comparer x = ((?<-) SortWith) comparer x


type SplitInto = SplitInto with
    static member inline (?<-) (SplitInto, count, x) = Seq.splitInto count x
    static member inline (?<-) (SplitInto, count, x) = List.splitInto count x
    static member inline (?<-) (SplitInto, count, x) = Array.splitInto count x
let inline splitInto count x = ((?<-) SplitInto) count x


type Sum = Sum with
    static member inline (?<-) (Sum, x) = Seq.sum x
    static member inline (?<-) (Sum, x) = List.sum x
    static member inline (?<-) (Sum, x) = Array.sum x
let inline sum x = ((?<-) Sum) x


type SumBy = SumBy with
    static member inline (?<-) (SumBy, projection, x) = Seq.sumBy projection x
    static member inline (?<-) (SumBy, projection, x) = List.sumBy projection x
    static member inline (?<-) (SumBy, projection, x) = Array.sumBy projection x
let inline sumBy projection x = ((?<-) SumBy) projection x


type Tail = Tail with
    static member inline (?<-) (Tail, x) = Seq.tail x
    static member inline (?<-) (Tail, x) = List.tail x
    static member inline (?<-) (Tail, x) = Array.tail x
let inline tail x = ((?<-) Tail) x


type Take = Take with
    static member inline (?<-) (Take, count, x) = Seq.take count x
    static member inline (?<-) (Take, count, x) = List.take count x
    static member inline (?<-) (Take, count, x) = Array.take count x
let inline take count x = ((?<-) Take) count x


type TakeWhile = TakeWhile with
    static member inline (?<-) (TakeWhile, predicate, x) = Seq.takeWhile predicate x
    static member inline (?<-) (TakeWhile, predicate, x) = List.takeWhile predicate x
    static member inline (?<-) (TakeWhile, predicate, x) = Array.takeWhile predicate x
let inline takeWhile predicate x = ((?<-) TakeWhile) predicate x


type Truncate = Truncate with
    static member inline (?<-) (Truncate, count, x) = Seq.truncate count x
    static member inline (?<-) (Truncate, count, x) = List.truncate count x
    static member inline (?<-) (Truncate, count, x) = Array.truncate count x
let inline truncate count x = ((?<-) Truncate) count x


type TryExactlyOne = TryExactlyOne with
    static member inline (?<-) (TryExactlyOne, x) = Seq.tryExactlyOne x
    static member inline (?<-) (TryExactlyOne, x) = List.tryExactlyOne x
    static member inline (?<-) (TryExactlyOne, x) = Array.tryExactlyOne x
let inline tryExactlyOne x = ((?<-) TryExactlyOne) x


type TryFind = TryFind with
    static member inline (?<-) (TryFind, predicate, x) = Seq.tryFind predicate x
    static member inline (?<-) (TryFind, predicate, x) = List.tryFind predicate x
    static member inline (?<-) (TryFind, predicate, x) = Array.tryFind predicate x
let inline tryFind predicate x = ((?<-) TryFind) predicate x


type TryFindBack = TryFindBack with
    static member inline (?<-) (TryFindBack, predicate, x) = Seq.tryFindBack predicate x
    static member inline (?<-) (TryFindBack, predicate, x) = List.tryFindBack predicate x
    static member inline (?<-) (TryFindBack, predicate, x) = Array.tryFindBack predicate x
let inline tryFindBack predicate x = ((?<-) TryFindBack) predicate x


type TryFindIndex = TryFindIndex with
    static member inline (?<-) (TryFindIndex, predicate, x) = Seq.tryFindIndex predicate x
    static member inline (?<-) (TryFindIndex, predicate, x) = List.tryFindIndex predicate x
    static member inline (?<-) (TryFindIndex, predicate, x) = Array.tryFindIndex predicate x
let inline tryFindIndex predicate x = ((?<-) TryFindIndex) predicate x


type TryFindIndexBack = TryFindIndexBack with
    static member inline (?<-) (TryFindIndexBack, predicate, x) = Seq.tryFindIndexBack predicate x
    static member inline (?<-) (TryFindIndexBack, predicate, x) = List.tryFindIndexBack predicate x
    static member inline (?<-) (TryFindIndexBack, predicate, x) = Array.tryFindIndexBack predicate x
let inline tryFindIndexBack predicate x = ((?<-) TryFindIndexBack) predicate x


type TryHead = TryHead with
    static member inline (?<-) (TryHead, x) = Seq.tryHead x
    static member inline (?<-) (TryHead, x) = List.tryHead x
    static member inline (?<-) (TryHead, x) = Array.tryHead x
let inline tryHead x = ((?<-) TryHead) x


type TryItem = TryItem with
    static member inline (?<-) (TryItem, index, x) = Seq.tryItem index x
    static member inline (?<-) (TryItem, index, x) = List.tryItem index x
    static member inline (?<-) (TryItem, index, x) = Array.tryItem index x
let inline tryItem index x = ((?<-) TryItem) index x


type TryLast = TryLast with
    static member inline (?<-) (TryLast, x) = Seq.tryLast x
    static member inline (?<-) (TryLast, x) = List.tryLast x
    static member inline (?<-) (TryLast, x) = Array.tryLast x
let inline tryLast x = ((?<-) TryLast) x


type TryPick = TryPick with
    static member inline (?<-) (TryPick, chooser, x) = Seq.tryPick chooser x
    static member inline (?<-) (TryPick, chooser, x) = List.tryPick chooser x
    static member inline (?<-) (TryPick, chooser, x) = Array.tryPick chooser x
let inline tryPick chooser x = ((?<-) TryPick) chooser x


// TODO
// type Unfold = Unfold with
//     static member inline (?<-) (Unfold, generator, state) = Seq.unfold generator state
//     static member inline (?<-) (Unfold, generator, state) = List.unfold generator state
//     static member inline (?<-) (Unfold, generator, state) = Array.unfold generator state
// let inline unfold generator state = ((?<-) Unfold) generator state
// type Unfold = Unfold with
//     static member inline (?<-) (Unfold, generator) = fun state -> Seq.unfold generator state
//     static member inline (?<-) (Unfold, generator) = fun state -> List.unfold generator state
//     static member inline (?<-) (Unfold, generator) = fun state -> Array.unfold generator state
// let inline unfold generator state = ((?<-) Unfold) generator state


type Where = Where with
    static member inline (?<-) (Where, predicate, x) = Seq.where predicate x
    static member inline (?<-) (Where, predicate, x) = List.where predicate x
    static member inline (?<-) (Where, predicate, x) = Array.where predicate x
let inline where predicate x = ((?<-) Where) predicate x


type Windowed = Windowed with
    static member inline (?<-) (Windowed, windowSize, x) = Seq.windowed windowSize x
    static member inline (?<-) (Windowed, windowSize, x) = List.windowed windowSize x
    static member inline (?<-) (Windowed, windowSize, x) = Array.windowed windowSize x
let inline windowed windowSize x = ((?<-) Windowed) windowSize x


type Zip = Zip with
    static member inline (?<-) (Zip, x1, x2) = Seq.zip x1 x2
    static member inline (?<-) (Zip, x1, x2) = List.zip x1 x2
    static member inline (?<-) (Zip, x1, x2) = Array.zip x1 x2
let inline zip x1 x2 = ((?<-) Zip) x1 x2


type Zip3 = Zip3 with
    static member inline (?<-) (Zip3, x1, x2, x3) = Seq.zip3 x1 x2 x3
    static member inline (?<-) (Zip3, x1, x2, x3) = List.zip3 x1 x2 x3
    static member inline (?<-) (Zip3, x1, x2, x3) = Array.zip3 x1 x2 x3
let inline zip3 x1 x2 x3 = ((?<-) Zip3) x1 x2 x3



// module private Test =

//     let aList = [ 1;2;3 ]
//     let anArray = [| 1;2;3 |]
//     let aSeq = seq { yield 1; yield 2; yield 3 }

//     map ((+) 1) aList
//     map ((+) 1) anArray 
//     map ((+) 1) aSeq 
//     map ((+) 1) 1

//     reduce (+) aList
//     reduce (+) anArray
//     reduce (+) aSeq

//     (*
//     List.collect
//     List.append
//     List.choose
//     *)

