# AABTools
Android App Bundle 安装工具

1. 将xxx.aab 生成 xxx.apks
```
bundletool build-apks --bundle=/MyApp/my_app.aab --output=/MyApp/my_app.apks
--ks=/MyApp/keystore.jks
--ks-pass=file:/MyApp/keystore.pwd
--ks-key-alias=MyKeyAlias
--key-pass=file:/MyApp/key.pwd
```
2. 将xxx.apks 安装到指定的设备上。
```
bundletool install-apks --apks=/MyApp/my_app.apks --device-id=<serial-id>
```
