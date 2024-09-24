dotnet new web -lang "C#" -n singleton-scoped-transient

curl http://localhost:5001

```
Singleton instance: ced68728-b5cc-463e-8334-6b5ee4939cf1

Scoped instance 1: 73156a86-8b7b-4645-aab8-6731d0c7384b
Scoped instance 2: 73156a86-8b7b-4645-aab8-6731d0c7384b

Transient instance 1: 887837ed-c106-4a86-8080-e28ec554706f
Transient instance 2: 5901b98f-8577-4cce-9936-ca3865d6be0f
```

```
Singleton instance: ced68728-b5cc-463e-8334-6b5ee4939cf1

Scoped instance 1: 81019f2d-3046-4ebb-bef8-ad0d92baafbe
Scoped instance 2: 81019f2d-3046-4ebb-bef8-ad0d92baafbe

Transient instance 1: a8bf77ba-e92a-4e6a-9af2-e2b9547be784
Transient instance 2: 9e418c67-aa50-475f-b644-5e6e1f0c80dc
```
