# Prototype

## Summary
Prototype means an object follows an interface containg a clone method. You create different objects
with different configurations. When you need an object like one of the ones you have configured you clone it,
instead of creating a new one through various other ways.

## When to use
When your objects have too many fields and configurations to use subclasses in a factory
or even a builder, cloning the objects might be a good approach.

## Why?
Prototype is great because it lets you copy and object without knowing anything about it's type.
All you need to depend on is the interface.