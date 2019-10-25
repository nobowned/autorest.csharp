﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using AutoRest.CSharp.V3.Utilities;
using YamlDotNet.Core;
using YamlDotNet.Serialization;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
// ReSharper disable once CheckNamespace
namespace AutoRest.CSharp.V3.Pipeline.Generated
{
    internal partial class CSharpLanguage
    {
        [YamlMember(Alias = "uid", Order = 0)]
        public string Uid { get; set; }

        [YamlMember(Alias = "name", Order = 1)]
        public string? Name { get; set; }

        [YamlMember(Alias = "description", Order = 2)]
        public string? Description { get; set; }

        [YamlMember(Alias = "type", Order = 3)]
        public CSharpType? Type { get; set; }

        [YamlIgnore]
        public int SchemaOrder { get; set; }
    }

    internal class CSharpNamespace
    {
        [YamlMember(Alias = "base", Order = 0)]
        public string? Base { get; set; }

        [YamlMember(Alias = "category", Order = 1)]
        public string? Category { get; set; }

        [YamlMember(Alias = "apiVersion", Order = 2)]
        public string? ApiVersion { get; set; }

        [YamlIgnore]
        public string FullName => new [] { Base, Category, ApiVersion }.JoinIgnoreEmpty(".");
    }

    internal class CSharpType
    {
        private Type? CreateFrameworkType() => Namespace?.FullName != null && Name != null ? Assembly.GetExecutingAssembly().GetType(FullName) : _frameworkType;

        private CSharpNamespace? _namespace;
        [YamlMember(Alias = "namespace", Order = 0)]
        public CSharpNamespace? Namespace
        {
            get => _namespace;
            set
            {
                _namespace = value;
                _frameworkType = CreateFrameworkType();
            }
        }

        private string? _name;
        [YamlMember(Alias = "name", Order = 1)]
        public string? Name
        {
            get => _name;
            set
            {
                _name = value;
                _frameworkType = CreateFrameworkType();
            }
        }

        [YamlIgnore]
        public string FullName => new[] { Namespace?.FullName, Name }.JoinIgnoreEmpty(".");

        private Type? _frameworkType;
        [YamlIgnore]
        public Type? FrameworkType
        {
            get => _frameworkType;
            set
            {
                _frameworkType = value;
                if (_frameworkType == null) return;

                _namespace ??= new CSharpNamespace();
                _namespace.Base = _frameworkType.Namespace;
                _namespace.Category = null;
                _namespace.ApiVersion = null;
                _name = _frameworkType.Name;
            }
        }
    }

    /// <summary>language metadata specific to schema instances</summary>
    internal partial class Language : IDictionary<string, object>
    {
        /// <summary>namespace of the implementation of this item</summary>
        [YamlMember(Alias = "namespace", Order = 2)]
        public string Namespace { get; set; }

        /// <summary>if this is a child of a polymorphic class, this will have the value of the discriminator.</summary>
        [YamlMember(Alias = "discriminatorValue", Order = 3)]
        public string DiscriminatorValue { get; set; }

        [YamlMember(Alias = "uid", Order = 4, ScalarStyle = ScalarStyle.SingleQuoted)]
        public string Uid { get; set; }

        [YamlMember(Alias = "internal", Order = 5)]
        public bool Internal { get; set; }

        [YamlIgnore]
        public IDictionary<string, object> AdditionalProperties = new Dictionary<string, object>();

        private readonly Dictionary<string, object> _dictionary = new Dictionary<string, object>();
        private static readonly Dictionary<string, PropertyInfo> DeserializableProperties = typeof(Language).GetDeserializableProperties();

        // Workaround for mapping properties from the dictionary entries
        private void AddAndMap(string key, object value)
        {
            _dictionary.Add(key, value);

            if (DeserializableProperties.ContainsKey(key))
            {
                var propInfo = DeserializableProperties[key];
                propInfo.SetValue(this, propInfo.DeserializeDictionary(value));
                return;
            }

            AdditionalProperties.Add(key, value);
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => _dictionary.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Add(KeyValuePair<string, object> item) => AddAndMap(item.Key, item.Value);
        public void Clear() => _dictionary.Clear();
        public bool Contains(KeyValuePair<string, object> item) => _dictionary.ContainsKey(item.Key);
        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            foreach (var item in _dictionary)
            {
                array[arrayIndex++] = item;
            }
        }
        public bool Remove(KeyValuePair<string, object> item) => _dictionary.Remove(item.Key);

        public int Count => _dictionary.Count;
        public bool IsReadOnly => false;
        public void Add(string key, object value) => AddAndMap(key, value);
        public bool ContainsKey(string key) => _dictionary.ContainsKey(key);
        public bool Remove(string key) => _dictionary.Remove(key);

        public bool TryGetValue(string key, out object value)
        {
            var result = _dictionary.TryGetValue(key, out var outValue);
            value = outValue ?? String.Empty;
            return result;
        }

        public object this[string key]
        {
            get => _dictionary[key];
            set => AddAndMap(key, value);
        }

        public ICollection<string> Keys => _dictionary.Keys;
        public ICollection<object> Values => _dictionary.Values;
    }
}
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
