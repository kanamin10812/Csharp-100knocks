using System;
namespace CSharp100Knocks
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 基本文法 */
            // //問1 Hello, World!と出力
            // Console.WriteLine("問1");
            // knock01 knock01 = new();
            // knock01.sayHello();

            // //問2 int型の変数xに10を代入して出力
            // Console.WriteLine("問2");
            // knock02 knock02 = new();
            // knock02.outputInt();

            // //問3 2つの数(3と5)の和を出力
            // Console.WriteLine("問3");
            // knock03 knock03 = new();
            // knock03.outputSum();

            // //問4 double型で割り算7÷2の結果を出力
            // knock04 knock04 = new();
            // knock04.outputQuot();

            // //問5 bool型の変数flagでtrueを出力
            // knock05 knock05 = new();
            // knock05.outputBool();

            // //問6 if文でxが正の時に"Positive"と出力
            // knock06 knock06 = new();
            // knock06.outputIf();

            // //問7 偶数/奇数を判定して出力
            // knock07 knock07 = new();
            // knock07.outputEvenOdd();

            // //問8 switch文で1→"One",2→"Two",それ以外→"Other"と出力
            // knock08 knock08 = new();
            // knock08.outputSwitch();

            // //問9 for文を使って1から5まで出力
            // knock09 knock09 = new();
            // knock09.outputFor();

            // //問10 while文を使って1から5まで出力
            // knock10 knock10 = new();
            // knock10.outputWhile();

            // //問11　do~while文を使って1から5まで出力
            // knock11 knock11 = new();
            // knock11.outputDoWhile();

            // //問12 三項演算子を使って、x>=10なら"OK"、そうでなければ"NG"と出力
            // knock12 knock12 = new();
            // knock12.outputTernary();

            // //問13 AND演算子を使って、「5以上かつ10以下」の時に"OK"と出力
            // knock13 knock13 = new();
            // knock13.outputAnd();

            // // 問14 OR演算子を使って、「0または10」の時に"OK"と出力
            // knock14 knock14 = new();
            // knock14.outputOR();

            // //問15 NOT演算子を使って、flagがfalseの時に"OFF"と出力
            // knock15 knock15 = new();
            // knock15.outputNot();

            // //問16 constでPIを定義して半径2の円の面積を出力（円周率は3.14とする）
            // knock16 knock16 = new();
            // knock16.outputConst();

            // //問17 文字列を連結して「Hello, World!」と出力
            // knock17 knock17 = new();
            // knock17.outputConcat();

            // //問18 文字列補間を使って「私の名前は○○です」と出力
            // knock18 knock18 = new();
            // knock18.outputComplement();

            // //問19 null合体演算子を使って、nullなら"Default"、そうでなければ変数の値を出力
            // knock19 knock19 = new();
            // knock19.outputNullCoalescing();

            // //問20 is演算子を使って、変数がstring型なら"String型です"と出力
            // knock20 knock20 = new();
            // knock20.outputIs();

            /* コレクション */
            // //問21 配列{1,2,3}の要素をすべて出力
            // knock21 knock21 = new();
            // knock21.outputArray();    

            // //問22 長さ5の配列を出力（初期値0)
            // knock22 knock22 = new();
            // knock22.outputArrayLen();

            // //問23 List<int>の要素の平均値を出力
            // knock23 knock23 = new();
            // knock23.outputListAvg();

            // //問24 Dictionary<string,string>を使って英和一件のDictionaryを作成し、要素を出力
            // knock24 knock24 = new();
            // knock24.outputDict();

            // //問25 QueueのEnqueueとDequeueを使って要素を出力
            // knock25 knock25 = new();
            // knock25.outputQueue();

            // //問26 StackのPushとPopを使って要素を出力
            // knock26 knock26 = new();
            // knock26.outputStack();

            // //問27 配列の要素を逆順にして出力
            // knock27 knock27 = new();
            // knock27.outputReverse();

            // //問28 配列を昇順にソートして出力
            // knock28 knock28 = new();
            // knock28.outputSort();

            // //問29 Listに特定の要素が含まれているかを出力
            // knock29 knock29 = new();
            // knock29.outputListContaints();

            //問30 DictionaryのTryGetValueを使って要素を出力
            knock30 knock30 = new();
            knock30.outputTryGetValue();

            //問31 HashSetで重複を削除して要素を出力

            //問32 配列の最大値を出力

            //問33 配列の最小値を出力

            //問34 Listを配列に変換してLengthを出力

            //問35 配列をListに変換してCountを出力

            /* メソッド・スコープ */
            //問36 Add(a,b)を使って3と5を足して出力

            //問37 規定値引数を使って引数なしで計算した結果を出力

            //問38 outを使用して平方根を計算した結果を出力

            //問39 refを使用して2倍の数を出力

            //問40 staticメソッドを使用して「Hello, World!」と出力

            //問41 intの加算にdoubleの加算によるオーバーロードを出力

            //問42 名前付き引数を使用して「a--b--c」と出力

            //問43 paramsを使用して合計を出力

            //問44 式本体を使用して絶対値を出力

            //問45 ローカル関数を使用して正方形の面積を出力

            //問46 Funcを使用して加算器の結果を出力

            //問47 Actionを使用して「Hello, World!」と出力

            //問48 PredicateとList.FindAllを使用して偶数を出力

            //問49 クロージャカウンタの結果を出力

            //問50 refで2つの数を入れ替えて出力（値渡しとの差を確認）

            /* クラス・オブジェクト指向 */
            //問51 Personクラスを作成してインスタンスの名前を出力

            //問52 必須コンストラクタを使用してPersonクラスの名前を出力

            //問53 privateフィールドを使用してカウンターを作成して出力（カプセル化）

            //問54 自動実装プロパティ初期値でPort番号8080を出力

            //問55 読み取り専用プロパティを使用して円の面積を出力

            //問56 init専用プロパティを使用して名前と年齢を出力

            //問57 ToString()をオーバーライドしてインスタンスの情報を出力

            //問58 Animalクラスを継承したDogクラスで鳴き声を出力

            //問59 抽象クラスを継承して円の面積を出力

            //問60 インターフェースの実装

            //問61 明示的インターフェースの実装

            //問62 searledを使用して継承できないクラスを作成

            //問63 静的メンバを使用してインスタンスの個数を出力

            //問64 constとreadonlyの違いを出力

            //問65 プロパティでバリデーションを行う

            //問66 baseを使った共通処理と拡張

            //問67 sealed overrideを使ってオーバーライド禁止

            //問68 recordを使って値の等価性を出力

            //問69 クラスの参照等価性を出力

            //問70 演算子のオーバーロード(Vec2)

            /* 例外処理とファイル操作 */
            //問71 0除算をtry-catchで例外処理

            //問72 finallyが必ず実行されることをfinallyと出力して確認
            //問73 独自の例外を作成してスロー（負の値）
            //問74 usingを使ってファイルに書き込み
            //問75 ファイルの行数を取得して出力
            //問76 ファイルの数値行を取得して出力（不正な行は無視）
            //問77 ファイル存在チェック
            //問78 ディレクトリを作成してファイルを保存
            //問79 ファイルに追記
            //問80 Copy()を使ってファイルをコピー
            //問81 Move()を使ってファイルを移動（リネーム）
            //問82 JSONシリアライズ
            //問83 JSON読み込み
            //問84 XMLの作成&読み込み
            //問85 IDidposableを自作してusingで使用

            /* LINQ */
            //問86 WhereでListから偶数を抽出して出力
            //問87 Selectで配列の要素を大文字に変換して出力
            //問88 数値配列を昇順、降順でそれぞれ出力
            //問89 文字列配列を長さの短い順に出力
            //問90 文字列配列を先頭文字でGroupByして出力
            //問91 SelectManyで二次元配列を一次元に変換して出力
            //問92 数値配列をFirstOrDefault,Any,Allでそれぞれ出力
            //問93 数値配列をCount,Sum,Min,Max,Averageでそれぞれ出力
            //問94 users{id,name,deptId}とdepts{deptId,deptName}の2つのListをJoinして出力
            //問95 数値配列をDistinct,Union,Intersect,Exceptでそれぞれ出力

            /* まとめ・発展 */
            //問96 現在時刻とUTCをそれぞれ出力
            //問97 2つの日時の差を出力
            //問98 Nullable型の数値・文字列それぞれの??/?.の動作を出力
            //問99 enumとswitch文を使って曜日を出力
            //問100　1ケタの数字同士の四則演算を行う簡易電卓の作成

        }
    }
}
