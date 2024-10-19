# Debugless

Debugless is a dotnet library that helps debugging.

## Features

This section explains and demostrates Debugless features.

### Logging

Debugless has simple logging features. You can use Info and Warning Logging.

```c#
var debugless = new Debugl();
debugless.InfoLog("An info log line");
debugless.WarningLog("A warning log line");
```

### Tracing

Debugless can show method call information. So you can easly find call paths.

```c#
var debugless = new Debugl();
debugless.InfoLog("Unique number found !").CallInfo();
```

### Dumping

Debugless can dump any object to console. Also it works for nested objects.

```c#
var student = new Student()
{
	Id = 1,
	FirstName = "John",
	LastName = "Doe",
	BirthDate = DateTime.SpecifyKind(DateTime.Parse("1994.01.01 10:00:00"), DateTimeKind.Local),
	Gender = Genders.Male,
	Parent = new Parent()
	{
		NameSurname = "Marry Chann",
		TelephoneNumber = "+1234567890"
	}
};

var debugless = new Debugl();
debugless.DumpObject(student);
```

### Chaining

You can use all Debugless features with chaining. Its very usefull when you combine them.

```c#
var debugless = new Debugl();
debugless.InfoLog("Threesold exceeded.").CallInfo();
```

### Conditional Working

You can use all Debugless features with conditions. Just pass a Boolean parameter to any feature.

```c#
var debugless = new Debugl();
debugless.DumpObject(student, (student.Id == 2));
```
