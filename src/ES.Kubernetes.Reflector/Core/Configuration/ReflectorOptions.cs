﻿namespace ES.Kubernetes.Reflector.Core.Configuration;

public class ReflectorOptions
{
    public WatcherOptions? Watcher { get; set; }
    public KubernetesOptions? Kubernetes { get; set; }
}