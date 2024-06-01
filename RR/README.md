# Design Patterns

Цей документ містить опис шаблонів проектування та їх графічне подання у вигляді UML-діаграм, створених за допомогою інструменту візуалізації Mermaid.

## Prototype (Creational Pattern)

### Опис
Шаблон Prototype використовується для створення нових об'єктів шляхом клонування існуючих. Це корисно, коли створення нових об'єктів є дорогим або складним процесом.

### UML-діаграма класів
```mermaid
classDiagram
    class Prototype {
        +clone() : Prototype
    }
    class ConcretePrototype1 {
        +clone() : Prototype
    }
    class ConcretePrototype2 {
        +clone() : Prototype
    }
    Prototype <|-- ConcretePrototype1
    Prototype <|-- ConcretePrototype2
```

### UML-діаграма взаємодії
```mermaid
sequenceDiagram
    participant Client
    participant Prototype
    Client->>Prototype: clone()
    Prototype-->>Client: new Object
```

## Composite (Structural Pattern)

### Опис
Шаблон Composite дозволяє об'єднувати об'єкти в дерево структури для представлення ієрархії частина-ціле. Це дозволяє клієнтам поводитися з окремими об'єктами та їхніми композиціями однаково.

### UML-діаграма класів
```mermaid
classDiagram
    class Component {
        +operation() : void
    }
    class Leaf {
        +operation() : void
    }
    class Composite {
        +add(Component)
        +remove(Component)
        +operation() : void
    }
    Component <|-- Leaf
    Component <|-- Composite
    Composite --> Component
```

### UML-діаграма взаємодії
```mermaid
sequenceDiagram
    participant Client
    participant Composite
    participant Leaf
    Client->>Composite: operation()
    Composite->>Leaf: operation()
```

## Null Object (Behavioral Pattern)

### Опис
Шаблон Null Object представляє об'єкт з нейтральною поведінкою, що мінімізує необхідність перевірок на null.

### UML-діаграма класів
```mermaid
classDiagram
    class AbstractObject {
        +request() : void
    }
    class RealObject {
        +request() : void
    }
    class NullObject {
        +request() : void
    }
    AbstractObject <|-- RealObject
    AbstractObject <|-- NullObject
```

### UML-діаграма взаємодії
```mermaid
sequenceDiagram
    participant Client
    participant RealObject
    participant NullObject
    Client->>RealObject: request()
    RealObject-->>Client: perform action
    Client->>NullObject: request()
    NullObject-->>Client: do nothing
```

## Monitor Object (Concurrency Pattern)

### Опис
Шаблон Monitor Object дозволяє управляти доступом до об'єкта серед багатьох потоків, забезпечуючи синхронізацію.

### UML-діаграма класів
```mermaid
classDiagram
    class MonitorObject {
        +method() : void
    }
    class Thread1 {
        +run() : void
    }
    class Thread2 {
        +run() : void
    }
    Thread1 --> MonitorObject
    Thread2 --> MonitorObject
```

### UML-діаграма взаємодії
```mermaid
sequenceDiagram
    participant Thread1
    participant MonitorObject
    participant Thread2
    Thread1->>MonitorObject: method()
    Note right of MonitorObject: synchronized access
    Thread2->>MonitorObject: method()
```
