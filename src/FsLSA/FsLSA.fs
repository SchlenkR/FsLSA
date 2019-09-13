
#if INTERACTIVE
#else
module FsLSA
#endif

// type Functor = Functor with
//     static member inline ($) (Functor, f, x) = Seq.map f x
//     static member inline ($) (Functor, f, x) = List.map f x
//     static member inline ($) (Functor, f, x) = Array.map f x
//     // works also for external types
//     static member inline ($) (Functor, f, x:int) = f x
// let inline map f x = (($) Functor) f x

type ToList = ToList with
    static member inline ($) (ToList, x) = Seq.toList x
    static member inline ($) (ToList, x:list<_>) = x
    static member inline ($) (ToList, x) = Array.toList x
let inline toList x = (($) ToList) x

type ToArray = ToArray with
    static member inline ($) (ToArray, x) = Seq.toArray x
    static member inline ($) (ToArray, x) = List.toArray x
    static member inline ($) (ToArray, x:array<_>) = x
let inline toArray x = (($) ToArray) x

type ToSeq = ToSeq with
    static member inline ($) (ToSeq, x:seq<_>) = x
    static member inline ($) (ToSeq, x) = List.toSeq x
    static member inline ($) (ToSeq, x) = Array.toSeq x
let inline toSeq x = (($) ToSeq) x


// auto-generated from here



type AllPairs = AllPairs with
    static member inline ($) (AllPairs, x2) = fun x1 -> Seq.allPairs x1 x2
    static member inline ($) (AllPairs, x2) = fun x1 -> List.allPairs x1 x2
    static member inline ($) (AllPairs, x2) = fun x1 -> Array.allPairs x1 x2
let inline allPairs x1 x2 = (($) AllPairs) x2 x1


type Append = Append with
    static member inline ($) (Append, x2) = fun x1 -> Seq.append x1 x2
    static member inline ($) (Append, x2) = fun x1 -> List.append x1 x2
    static member inline ($) (Append, x2) = fun x1 -> Array.append x1 x2
let inline append x1 x2 = (($) Append) x2 x1


type Average = Average with
    static member inline ($) (Average, x) = fun () -> Seq.average x
    static member inline ($) (Average, x) = fun () -> List.average x
    static member inline ($) (Average, x) = fun () -> Array.average x
let inline average x = (($) Average) x


type AverageBy = AverageBy with
    static member inline ($) (AverageBy, x) = fun projection -> Seq.averageBy projection x
    static member inline ($) (AverageBy, x) = fun projection -> List.averageBy projection x
    static member inline ($) (AverageBy, x) = fun projection -> Array.averageBy projection x
let inline averageBy projection x = (($) AverageBy) x projection


type Choose = Choose with
    static member inline ($) (Choose, x) = fun chooser -> Seq.choose chooser x
    static member inline ($) (Choose, x) = fun chooser -> List.choose chooser x
    static member inline ($) (Choose, x) = fun chooser -> Array.choose chooser x
let inline choose chooser x = (($) Choose) x chooser


type ChunkBySize = ChunkBySize with
    static member inline ($) (ChunkBySize, x) = fun chunkSize -> Seq.chunkBySize chunkSize x
    static member inline ($) (ChunkBySize, x) = fun chunkSize -> List.chunkBySize chunkSize x
    static member inline ($) (ChunkBySize, x) = fun chunkSize -> Array.chunkBySize chunkSize x
let inline chunkBySize chunkSize x = (($) ChunkBySize) x chunkSize


type Collect = Collect with
    static member inline ($) (Collect, x) = fun mapping -> Seq.collect mapping x
    static member inline ($) (Collect, x) = fun mapping -> List.collect mapping x
    static member inline ($) (Collect, x) = fun mapping -> Array.collect mapping x
let inline collect mapping x = (($) Collect) x mapping


type CompareWith = CompareWith with
    static member inline ($) (CompareWith, x2) = fun x1 comparer -> Seq.compareWith comparer x1 x2
    static member inline ($) (CompareWith, x2) = fun x1 comparer -> List.compareWith comparer x1 x2
    static member inline ($) (CompareWith, x2) = fun x1 comparer -> Array.compareWith comparer x1 x2
let inline compareWith comparer x1 x2 = (($) CompareWith) x2 x1 comparer


type Concat = Concat with
    static member inline ($) (Concat, xs) = fun () -> Seq.concat xs
    static member inline ($) (Concat, xs) = fun () -> List.concat xs
    static member inline ($) (Concat, xs) = fun () -> Array.concat xs
let inline concat xs = (($) Concat) xs


type CountBy = CountBy with
    static member inline ($) (CountBy, x) = fun projection -> Seq.countBy projection x
    static member inline ($) (CountBy, x) = fun projection -> List.countBy projection x
    static member inline ($) (CountBy, x) = fun projection -> Array.countBy projection x
let inline countBy projection x = (($) CountBy) x projection


type Distinct = Distinct with
    static member inline ($) (Distinct, x) = fun () -> Seq.distinct x
    static member inline ($) (Distinct, x) = fun () -> List.distinct x
    static member inline ($) (Distinct, x) = fun () -> Array.distinct x
let inline distinct x = (($) Distinct) x


type DistinctBy = DistinctBy with
    static member inline ($) (DistinctBy, x) = fun projection -> Seq.distinctBy projection x
    static member inline ($) (DistinctBy, x) = fun projection -> List.distinctBy projection x
    static member inline ($) (DistinctBy, x) = fun projection -> Array.distinctBy projection x
let inline distinctBy projection x = (($) DistinctBy) x projection


type ExactlyOne = ExactlyOne with
    static member inline ($) (ExactlyOne, x) = fun () -> Seq.exactlyOne x
    static member inline ($) (ExactlyOne, x) = fun () -> List.exactlyOne x
    static member inline ($) (ExactlyOne, x) = fun () -> Array.exactlyOne x
let inline exactlyOne x = (($) ExactlyOne) x


type Except = Except with
    static member inline ($) (Except, x) = fun itemsToExclude -> Seq.except itemsToExclude x
    static member inline ($) (Except, x) = fun itemsToExclude -> List.except itemsToExclude x
    static member inline ($) (Except, x) = fun itemsToExclude -> Array.except itemsToExclude x
let inline except itemsToExclude x = (($) Except) x itemsToExclude


type Exists = Exists with
    static member inline ($) (Exists, x) = fun predicate -> Seq.exists predicate x
    static member inline ($) (Exists, x) = fun predicate -> List.exists predicate x
    static member inline ($) (Exists, x) = fun predicate -> Array.exists predicate x
let inline exists predicate x = (($) Exists) x predicate


type Exists2 = Exists2 with
    static member inline ($) (Exists2, x2) = fun x1 predicate -> Seq.exists2 predicate x1 x2
    static member inline ($) (Exists2, x2) = fun x1 predicate -> List.exists2 predicate x1 x2
    static member inline ($) (Exists2, x2) = fun x1 predicate -> Array.exists2 predicate x1 x2
let inline exists2 predicate x1 x2 = (($) Exists2) x2 x1 predicate


type Filter = Filter with
    static member inline ($) (Filter, x) = fun predicate -> Seq.filter predicate x
    static member inline ($) (Filter, x) = fun predicate -> List.filter predicate x
    static member inline ($) (Filter, x) = fun predicate -> Array.filter predicate x
let inline filter predicate x = (($) Filter) x predicate


type Find = Find with
    static member inline ($) (Find, x) = fun predicate -> Seq.find predicate x
    static member inline ($) (Find, x) = fun predicate -> List.find predicate x
    static member inline ($) (Find, x) = fun predicate -> Array.find predicate x
let inline find predicate x = (($) Find) x predicate


type FindBack = FindBack with
    static member inline ($) (FindBack, x) = fun predicate -> Seq.findBack predicate x
    static member inline ($) (FindBack, x) = fun predicate -> List.findBack predicate x
    static member inline ($) (FindBack, x) = fun predicate -> Array.findBack predicate x
let inline findBack predicate x = (($) FindBack) x predicate


type FindIndex = FindIndex with
    static member inline ($) (FindIndex, x) = fun predicate -> Seq.findIndex predicate x
    static member inline ($) (FindIndex, x) = fun predicate -> List.findIndex predicate x
    static member inline ($) (FindIndex, x) = fun predicate -> Array.findIndex predicate x
let inline findIndex predicate x = (($) FindIndex) x predicate


type FindIndexBack = FindIndexBack with
    static member inline ($) (FindIndexBack, x) = fun predicate -> Seq.findIndexBack predicate x
    static member inline ($) (FindIndexBack, x) = fun predicate -> List.findIndexBack predicate x
    static member inline ($) (FindIndexBack, x) = fun predicate -> Array.findIndexBack predicate x
let inline findIndexBack predicate x = (($) FindIndexBack) x predicate


type Fold = Fold with
    static member inline ($) (Fold, x) = fun state folder -> Seq.fold folder state x
    static member inline ($) (Fold, x) = fun state folder -> List.fold folder state x
    static member inline ($) (Fold, x) = fun state folder -> Array.fold folder state x
let inline fold folder state x = (($) Fold) x state folder


type Fold2 = Fold2 with
    static member inline ($) (Fold2, x2) = fun x1 state folder -> Seq.fold2 folder state x1 x2
    static member inline ($) (Fold2, x2) = fun x1 state folder -> List.fold2 folder state x1 x2
    static member inline ($) (Fold2, x2) = fun x1 state folder -> Array.fold2 folder state x1 x2
let inline fold2 folder state x1 x2 = (($) Fold2) x2 x1 state folder


type Forall = Forall with
    static member inline ($) (Forall, x) = fun predicate -> Seq.forall predicate x
    static member inline ($) (Forall, x) = fun predicate -> List.forall predicate x
    static member inline ($) (Forall, x) = fun predicate -> Array.forall predicate x
let inline forall predicate x = (($) Forall) x predicate


type Forall2 = Forall2 with
    static member inline ($) (Forall2, x2) = fun x1 predicate -> Seq.forall2 predicate x1 x2
    static member inline ($) (Forall2, x2) = fun x1 predicate -> List.forall2 predicate x1 x2
    static member inline ($) (Forall2, x2) = fun x1 predicate -> Array.forall2 predicate x1 x2
let inline forall2 predicate x1 x2 = (($) Forall2) x2 x1 predicate


type GroupBy = GroupBy with
    static member inline ($) (GroupBy, x) = fun projection -> Seq.groupBy projection x
    static member inline ($) (GroupBy, x) = fun projection -> List.groupBy projection x
    static member inline ($) (GroupBy, x) = fun projection -> Array.groupBy projection x
let inline groupBy projection x = (($) GroupBy) x projection


type Head = Head with
    static member inline ($) (Head, x) = fun () -> Seq.head x
    static member inline ($) (Head, x) = fun () -> List.head x
    static member inline ($) (Head, x) = fun () -> Array.head x
let inline head x = (($) Head) x


type Indexed = Indexed with
    static member inline ($) (Indexed, x) = fun () -> Seq.indexed x
    static member inline ($) (Indexed, x) = fun () -> List.indexed x
    static member inline ($) (Indexed, x) = fun () -> Array.indexed x
let inline indexed x = (($) Indexed) x


type IsEmpty = IsEmpty with
    static member inline ($) (IsEmpty, x) = fun () -> Seq.isEmpty x
    static member inline ($) (IsEmpty, x) = fun () -> List.isEmpty x
    static member inline ($) (IsEmpty, x) = fun () -> Array.isEmpty x
let inline isEmpty x = (($) IsEmpty) x


type Item = Item with
    static member inline ($) (Item, x) = fun index -> Seq.item index x
    static member inline ($) (Item, x) = fun index -> List.item index x
    static member inline ($) (Item, x) = fun index -> Array.item index x
let inline item index x = (($) Item) x index


type Iter = Iter with
    static member inline ($) (Iter, x) = fun action -> Seq.iter action x
    static member inline ($) (Iter, x) = fun action -> List.iter action x
    static member inline ($) (Iter, x) = fun action -> Array.iter action x
let inline iter action x = (($) Iter) x action


type Iter2 = Iter2 with
    static member inline ($) (Iter2, x2) = fun x1 action -> Seq.iter2 action x1 x2
    static member inline ($) (Iter2, x2) = fun x1 action -> List.iter2 action x1 x2
    static member inline ($) (Iter2, x2) = fun x1 action -> Array.iter2 action x1 x2
let inline iter2 action x1 x2 = (($) Iter2) x2 x1 action


type Iteri = Iteri with
    static member inline ($) (Iteri, x) = fun action -> Seq.iteri action x
    static member inline ($) (Iteri, x) = fun action -> List.iteri action x
    static member inline ($) (Iteri, x) = fun action -> Array.iteri action x
let inline iteri action x = (($) Iteri) x action


type Iteri2 = Iteri2 with
    static member inline ($) (Iteri2, x2) = fun x1 action -> Seq.iteri2 action x1 x2
    static member inline ($) (Iteri2, x2) = fun x1 action -> List.iteri2 action x1 x2
    static member inline ($) (Iteri2, x2) = fun x1 action -> Array.iteri2 action x1 x2
let inline iteri2 action x1 x2 = (($) Iteri2) x2 x1 action


type Last = Last with
    static member inline ($) (Last, x) = fun () -> Seq.last x
    static member inline ($) (Last, x) = fun () -> List.last x
    static member inline ($) (Last, x) = fun () -> Array.last x
let inline last x = (($) Last) x


type Length = Length with
    static member inline ($) (Length, x) = fun () -> Seq.length x
    static member inline ($) (Length, x) = fun () -> List.length x
    static member inline ($) (Length, x) = fun () -> Array.length x
let inline length x = (($) Length) x


type Map = Map with
    static member inline ($) (Map, x) = fun mapping -> Seq.map mapping x
    static member inline ($) (Map, x) = fun mapping -> List.map mapping x
    static member inline ($) (Map, x) = fun mapping -> Array.map mapping x
let inline map mapping x = (($) Map) x mapping


type Map2 = Map2 with
    static member inline ($) (Map2, x2) = fun x1 mapping -> Seq.map2 mapping x1 x2
    static member inline ($) (Map2, x2) = fun x1 mapping -> List.map2 mapping x1 x2
    static member inline ($) (Map2, x2) = fun x1 mapping -> Array.map2 mapping x1 x2
let inline map2 mapping x1 x2 = (($) Map2) x2 x1 mapping


type Map3 = Map3 with
    static member inline ($) (Map3, x3) = fun x2 x1 mapping -> Seq.map3 mapping x1 x2 x3
    static member inline ($) (Map3, x3) = fun x2 x1 mapping -> List.map3 mapping x1 x2 x3
    static member inline ($) (Map3, x3) = fun x2 x1 mapping -> Array.map3 mapping x1 x2 x3
let inline map3 mapping x1 x2 x3 = (($) Map3) x3 x2 x1 mapping


type MapFold = MapFold with
    static member inline ($) (MapFold, x) = fun state mapping -> Seq.mapFold mapping state x
    static member inline ($) (MapFold, x) = fun state mapping -> List.mapFold mapping state x
    static member inline ($) (MapFold, x) = fun state mapping -> Array.mapFold mapping state x
let inline mapFold mapping state x = (($) MapFold) x state mapping


type Mapi = Mapi with
    static member inline ($) (Mapi, x) = fun mapping -> Seq.mapi mapping x
    static member inline ($) (Mapi, x) = fun mapping -> List.mapi mapping x
    static member inline ($) (Mapi, x) = fun mapping -> Array.mapi mapping x
let inline mapi mapping x = (($) Mapi) x mapping


type Mapi2 = Mapi2 with
    static member inline ($) (Mapi2, x2) = fun x1 mapping -> Seq.mapi2 mapping x1 x2
    static member inline ($) (Mapi2, x2) = fun x1 mapping -> List.mapi2 mapping x1 x2
    static member inline ($) (Mapi2, x2) = fun x1 mapping -> Array.mapi2 mapping x1 x2
let inline mapi2 mapping x1 x2 = (($) Mapi2) x2 x1 mapping


type Max = Max with
    static member inline ($) (Max, x) = fun () -> Seq.max x
    static member inline ($) (Max, x) = fun () -> List.max x
    static member inline ($) (Max, x) = fun () -> Array.max x
let inline max x = (($) Max) x


type MaxBy = MaxBy with
    static member inline ($) (MaxBy, x) = fun projection -> Seq.maxBy projection x
    static member inline ($) (MaxBy, x) = fun projection -> List.maxBy projection x
    static member inline ($) (MaxBy, x) = fun projection -> Array.maxBy projection x
let inline maxBy projection x = (($) MaxBy) x projection


type Min = Min with
    static member inline ($) (Min, x) = fun () -> Seq.min x
    static member inline ($) (Min, x) = fun () -> List.min x
    static member inline ($) (Min, x) = fun () -> Array.min x
let inline min x = (($) Min) x


type MinBy = MinBy with
    static member inline ($) (MinBy, x) = fun projection -> Seq.minBy projection x
    static member inline ($) (MinBy, x) = fun projection -> List.minBy projection x
    static member inline ($) (MinBy, x) = fun projection -> Array.minBy projection x
let inline minBy projection x = (($) MinBy) x projection


type Pairwise = Pairwise with
    static member inline ($) (Pairwise, x) = fun () -> Seq.pairwise x
    static member inline ($) (Pairwise, x) = fun () -> List.pairwise x
    static member inline ($) (Pairwise, x) = fun () -> Array.pairwise x
let inline pairwise x = (($) Pairwise) x


type Permute = Permute with
    static member inline ($) (Permute, x) = fun indexMap -> Seq.permute indexMap x
    static member inline ($) (Permute, x) = fun indexMap -> List.permute indexMap x
    static member inline ($) (Permute, x) = fun indexMap -> Array.permute indexMap x
let inline permute indexMap x = (($) Permute) x indexMap


type Pick = Pick with
    static member inline ($) (Pick, x) = fun chooser -> Seq.pick chooser x
    static member inline ($) (Pick, x) = fun chooser -> List.pick chooser x
    static member inline ($) (Pick, x) = fun chooser -> Array.pick chooser x
let inline pick chooser x = (($) Pick) x chooser


type Reduce = Reduce with
    static member inline ($) (Reduce, x) = fun reduction -> Seq.reduce reduction x
    static member inline ($) (Reduce, x) = fun reduction -> List.reduce reduction x
    static member inline ($) (Reduce, x) = fun reduction -> Array.reduce reduction x
let inline reduce reduction x = (($) Reduce) x reduction


type ReduceBack = ReduceBack with
    static member inline ($) (ReduceBack, x) = fun reduction -> Seq.reduceBack reduction x
    static member inline ($) (ReduceBack, x) = fun reduction -> List.reduceBack reduction x
    static member inline ($) (ReduceBack, x) = fun reduction -> Array.reduceBack reduction x
let inline reduceBack reduction x = (($) ReduceBack) x reduction


type Rev = Rev with
    static member inline ($) (Rev, x) = fun () -> Seq.rev x
    static member inline ($) (Rev, x) = fun () -> List.rev x
    static member inline ($) (Rev, x) = fun () -> Array.rev x
let inline rev x = (($) Rev) x


type Scan = Scan with
    static member inline ($) (Scan, x) = fun state folder -> Seq.scan folder state x
    static member inline ($) (Scan, x) = fun state folder -> List.scan folder state x
    static member inline ($) (Scan, x) = fun state folder -> Array.scan folder state x
let inline scan folder state x = (($) Scan) x state folder


type Skip = Skip with
    static member inline ($) (Skip, x) = fun count -> Seq.skip count x
    static member inline ($) (Skip, x) = fun count -> List.skip count x
    static member inline ($) (Skip, x) = fun count -> Array.skip count x
let inline skip count x = (($) Skip) x count


type SkipWhile = SkipWhile with
    static member inline ($) (SkipWhile, x) = fun predicate -> Seq.skipWhile predicate x
    static member inline ($) (SkipWhile, x) = fun predicate -> List.skipWhile predicate x
    static member inline ($) (SkipWhile, x) = fun predicate -> Array.skipWhile predicate x
let inline skipWhile predicate x = (($) SkipWhile) x predicate


type Sort = Sort with
    static member inline ($) (Sort, x) = fun () -> Seq.sort x
    static member inline ($) (Sort, x) = fun () -> List.sort x
    static member inline ($) (Sort, x) = fun () -> Array.sort x
let inline sort x = (($) Sort) x


type SortBy = SortBy with
    static member inline ($) (SortBy, x) = fun projection -> Seq.sortBy projection x
    static member inline ($) (SortBy, x) = fun projection -> List.sortBy projection x
    static member inline ($) (SortBy, x) = fun projection -> Array.sortBy projection x
let inline sortBy projection x = (($) SortBy) x projection


type SortByDescending = SortByDescending with
    static member inline ($) (SortByDescending, x) = fun projection -> Seq.sortByDescending projection x
    static member inline ($) (SortByDescending, x) = fun projection -> List.sortByDescending projection x
    static member inline ($) (SortByDescending, x) = fun projection -> Array.sortByDescending projection x
let inline sortByDescending projection x = (($) SortByDescending) x projection


type SortDescending = SortDescending with
    static member inline ($) (SortDescending, x) = fun () -> Seq.sortDescending x
    static member inline ($) (SortDescending, x) = fun () -> List.sortDescending x
    static member inline ($) (SortDescending, x) = fun () -> Array.sortDescending x
let inline sortDescending x = (($) SortDescending) x


type SortWith = SortWith with
    static member inline ($) (SortWith, x) = fun comparer -> Seq.sortWith comparer x
    static member inline ($) (SortWith, x) = fun comparer -> List.sortWith comparer x
    static member inline ($) (SortWith, x) = fun comparer -> Array.sortWith comparer x
let inline sortWith comparer x = (($) SortWith) x comparer


type SplitInto = SplitInto with
    static member inline ($) (SplitInto, x) = fun count -> Seq.splitInto count x
    static member inline ($) (SplitInto, x) = fun count -> List.splitInto count x
    static member inline ($) (SplitInto, x) = fun count -> Array.splitInto count x
let inline splitInto count x = (($) SplitInto) x count


type Sum = Sum with
    static member inline ($) (Sum, x) = fun () -> Seq.sum x
    static member inline ($) (Sum, x) = fun () -> List.sum x
    static member inline ($) (Sum, x) = fun () -> Array.sum x
let inline sum x = (($) Sum) x


type SumBy = SumBy with
    static member inline ($) (SumBy, x) = fun projection -> Seq.sumBy projection x
    static member inline ($) (SumBy, x) = fun projection -> List.sumBy projection x
    static member inline ($) (SumBy, x) = fun projection -> Array.sumBy projection x
let inline sumBy projection x = (($) SumBy) x projection


type Tail = Tail with
    static member inline ($) (Tail, x) = fun () -> Seq.tail x
    static member inline ($) (Tail, x) = fun () -> List.tail x
    static member inline ($) (Tail, x) = fun () -> Array.tail x
let inline tail x = (($) Tail) x


type Take = Take with
    static member inline ($) (Take, x) = fun count -> Seq.take count x
    static member inline ($) (Take, x) = fun count -> List.take count x
    static member inline ($) (Take, x) = fun count -> Array.take count x
let inline take count x = (($) Take) x count


type TakeWhile = TakeWhile with
    static member inline ($) (TakeWhile, x) = fun predicate -> Seq.takeWhile predicate x
    static member inline ($) (TakeWhile, x) = fun predicate -> List.takeWhile predicate x
    static member inline ($) (TakeWhile, x) = fun predicate -> Array.takeWhile predicate x
let inline takeWhile predicate x = (($) TakeWhile) x predicate


type Truncate = Truncate with
    static member inline ($) (Truncate, x) = fun count -> Seq.truncate count x
    static member inline ($) (Truncate, x) = fun count -> List.truncate count x
    static member inline ($) (Truncate, x) = fun count -> Array.truncate count x
let inline truncate count x = (($) Truncate) x count


type TryExactlyOne = TryExactlyOne with
    static member inline ($) (TryExactlyOne, x) = fun () -> Seq.tryExactlyOne x
    static member inline ($) (TryExactlyOne, x) = fun () -> List.tryExactlyOne x
    static member inline ($) (TryExactlyOne, x) = fun () -> Array.tryExactlyOne x
let inline tryExactlyOne x = (($) TryExactlyOne) x


type TryFind = TryFind with
    static member inline ($) (TryFind, x) = fun predicate -> Seq.tryFind predicate x
    static member inline ($) (TryFind, x) = fun predicate -> List.tryFind predicate x
    static member inline ($) (TryFind, x) = fun predicate -> Array.tryFind predicate x
let inline tryFind predicate x = (($) TryFind) x predicate


type TryFindBack = TryFindBack with
    static member inline ($) (TryFindBack, x) = fun predicate -> Seq.tryFindBack predicate x
    static member inline ($) (TryFindBack, x) = fun predicate -> List.tryFindBack predicate x
    static member inline ($) (TryFindBack, x) = fun predicate -> Array.tryFindBack predicate x
let inline tryFindBack predicate x = (($) TryFindBack) x predicate


type TryFindIndex = TryFindIndex with
    static member inline ($) (TryFindIndex, x) = fun predicate -> Seq.tryFindIndex predicate x
    static member inline ($) (TryFindIndex, x) = fun predicate -> List.tryFindIndex predicate x
    static member inline ($) (TryFindIndex, x) = fun predicate -> Array.tryFindIndex predicate x
let inline tryFindIndex predicate x = (($) TryFindIndex) x predicate


type TryFindIndexBack = TryFindIndexBack with
    static member inline ($) (TryFindIndexBack, x) = fun predicate -> Seq.tryFindIndexBack predicate x
    static member inline ($) (TryFindIndexBack, x) = fun predicate -> List.tryFindIndexBack predicate x
    static member inline ($) (TryFindIndexBack, x) = fun predicate -> Array.tryFindIndexBack predicate x
let inline tryFindIndexBack predicate x = (($) TryFindIndexBack) x predicate


type TryHead = TryHead with
    static member inline ($) (TryHead, x) = fun () -> Seq.tryHead x
    static member inline ($) (TryHead, x) = fun () -> List.tryHead x
    static member inline ($) (TryHead, x) = fun () -> Array.tryHead x
let inline tryHead x = (($) TryHead) x


type TryItem = TryItem with
    static member inline ($) (TryItem, x) = fun index -> Seq.tryItem index x
    static member inline ($) (TryItem, x) = fun index -> List.tryItem index x
    static member inline ($) (TryItem, x) = fun index -> Array.tryItem index x
let inline tryItem index x = (($) TryItem) x index


type TryLast = TryLast with
    static member inline ($) (TryLast, x) = fun () -> Seq.tryLast x
    static member inline ($) (TryLast, x) = fun () -> List.tryLast x
    static member inline ($) (TryLast, x) = fun () -> Array.tryLast x
let inline tryLast x = (($) TryLast) x


type TryPick = TryPick with
    static member inline ($) (TryPick, x) = fun chooser -> Seq.tryPick chooser x
    static member inline ($) (TryPick, x) = fun chooser -> List.tryPick chooser x
    static member inline ($) (TryPick, x) = fun chooser -> Array.tryPick chooser x
let inline tryPick chooser x = (($) TryPick) x chooser


type Where = Where with
    static member inline ($) (Where, x) = fun predicate -> Seq.where predicate x
    static member inline ($) (Where, x) = fun predicate -> List.where predicate x
    static member inline ($) (Where, x) = fun predicate -> Array.where predicate x
let inline where predicate x = (($) Where) x predicate


type Windowed = Windowed with
    static member inline ($) (Windowed, x) = fun windowSize -> Seq.windowed windowSize x
    static member inline ($) (Windowed, x) = fun windowSize -> List.windowed windowSize x
    static member inline ($) (Windowed, x) = fun windowSize -> Array.windowed windowSize x
let inline windowed windowSize x = (($) Windowed) x windowSize


type Zip = Zip with
    static member inline ($) (Zip, x2) = fun x1 -> Seq.zip x1 x2
    static member inline ($) (Zip, x2) = fun x1 -> List.zip x1 x2
    static member inline ($) (Zip, x2) = fun x1 -> Array.zip x1 x2
let inline zip x1 x2 = (($) Zip) x2 x1


type Zip3 = Zip3 with
    static member inline ($) (Zip3, x3) = fun x2 x1 -> Seq.zip3 x1 x2 x3
    static member inline ($) (Zip3, x3) = fun x2 x1 -> List.zip3 x1 x2 x3
    static member inline ($) (Zip3, x3) = fun x2 x1 -> Array.zip3 x1 x2 x3
let inline zip3 x1 x2 x3 = (($) Zip3) x3 x2 x1
