Json練習
====


## Description
### 

TODO

1.必要ファイルでシリアライズ

2. 撮影画面のカメラコンストラクタでboolに値をセット
```C#
public bool IsCameraStart{get;set}

public ScreenViewModel()
{
    try{
IsCameraStart = true;
    }
    catch{
IsCameraStart = false;
    }
}
```
インジケータ画面へのナビゲーション時にboolを渡すこと

3. boolの値で処理の切り替え
```c#

private Serialize serializer;
private Detection ml;

public WaitScreenViewModel(DetectionML detection)
{
    if(IsCameraStart)
    {
        // 起動時
        ml = detection;
        serializer = new Serialize();
    }
    else
    {
        ml = new Stubdetection(); // 通信しないで固定の結果を返すクラス
        serializer = new StubSerialize(); // test.jsonを返すクラス
    }
}
```

4. 
シリアライズクラスでデータをjson化したものをdetectionクラスに渡すように変更
処理はWaitScreenModel()でまとめておこなう


## Author
pisa