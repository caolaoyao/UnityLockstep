//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DestinationListenerComponent destinationListener { get { return (DestinationListenerComponent)GetComponent(GameComponentsLookup.DestinationListener); } }
    public bool hasDestinationListener { get { return HasComponent(GameComponentsLookup.DestinationListener); } }

    public void AddDestinationListener(System.Collections.Generic.List<IDestinationListener> newValue) {
        var index = GameComponentsLookup.DestinationListener;
        var component = (DestinationListenerComponent)CreateComponent(index, typeof(DestinationListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDestinationListener(System.Collections.Generic.List<IDestinationListener> newValue) {
        var index = GameComponentsLookup.DestinationListener;
        var component = (DestinationListenerComponent)CreateComponent(index, typeof(DestinationListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDestinationListener() {
        RemoveComponent(GameComponentsLookup.DestinationListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDestinationListener;

    public static Entitas.IMatcher<GameEntity> DestinationListener {
        get {
            if (_matcherDestinationListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DestinationListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDestinationListener = matcher;
            }

            return _matcherDestinationListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddDestinationListener(IDestinationListener value) {
        var listeners = hasDestinationListener
            ? destinationListener.value
            : new System.Collections.Generic.List<IDestinationListener>();
        listeners.Add(value);
        ReplaceDestinationListener(listeners);
    }

    public void RemoveDestinationListener(IDestinationListener value, bool removeComponentWhenEmpty = true) {
        var listeners = destinationListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveDestinationListener();
        } else {
            ReplaceDestinationListener(listeners);
        }
    }
}