# PaizaHelper4cs
ローカルで作成したソースを編集なしでPaiza上で実行するためのC#ライブラリ

## 使い方
### ローカルでのテスト実行
#### 提出予定のコード例
```C#
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Example.Paiza.Sample
{
    public class Sample1
    {
        public static void Main()
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
```
* 名前空間とクラス名は自由に決めていいみたい

#### 実行方法
```C#
PaizaHelper.Exec("Com.Example.Paiza.Sample.Sample1", "Sample", 1, "1 2\naaaa\nbbbb");
```
* 第一引数：実行対象クラスのフルネーム
* 第二引数：実行対象が含まれるアセンブリ名
* 第三引数：実行回数
* 第四引数：実行時標準入力に渡されるテストデータ（文字列）   
`PaizaHelper.Exec2`を使用することでテストデータを記載したファイルを渡すことができます

#### 実行結果
```
>>> exec Com.Example.Paiza.Sample.Sample1.Main
args:
1 2
aaaa
bbbb
>>> start
1 2
aaaa
bbbb
>>> done 1 times in 0ms.
```
* `>>> start`から`>>> done {n} times in {t}ms.`の間が出力結果です。


### Paizaへの提出
ローカルでテストしたコードをそのまま貼り付けて提出できます。
```C#
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Example.Paiza.Sample
{
    public class Sample1
    {
        public static void Main()
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
```

