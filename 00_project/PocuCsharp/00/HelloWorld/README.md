# HelloWorld

## 프로젝트 만들기

```bash
$ dotnet new console --use-program-main -o HelloWorld 
```

* `dotnet` 도구를 이용해서 프로젝트를 만들 수 있다. 콘솔 애플리케이션의 경우 `dotnet new console`이다.
* `--use-program-main` 옵션은 메인 함수를 작성하는 "엔트리포인트"를 만들겠다는 의미이다.
* `-o` 옵션은 프로젝트 이름을 지정할 때 사용한다. `-o HelloWorld`의 경우 HelloWorld라는 이름으로 프로젝트를 생성한다.

## .gitignore 추가하기

`git`에 저장할 때, 필요없는 파일들을 지정할 때, `.gitignore` 파일에 작성한다. `dotnet` 도구를 이용해서 손쉽게 만들 수 있다.

```bash
$ dotnet new gitignore
```

## 프로젝트 실행하기

`dotnet run` 명령어로 손쉽게 작성한 프로그램을 실행하 수 있다.

```bash
$ dotnet run
Hello, World!
```