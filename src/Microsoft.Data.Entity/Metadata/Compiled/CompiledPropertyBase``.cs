// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Microsoft.Data.Entity.Metadata.Compiled
{
    public class CompiledPropertyBase<TEntity, TProperty, TAnnotations>
        : CompiledPropertyBase<TEntity, TProperty>
        where TAnnotations : CompiledAnnotationsBase, new()
    {
        protected readonly LazyMetadataRef<TAnnotations> LazyAnnotations = new LazyMetadataRef<TAnnotations>();

        public new IEnumerable<IAnnotation> Annotations
        {
            get { return LazyAnnotations.Value.Annotations; }
        }

        public new string this[[NotNull] string annotationName]
        {
            get
            {
                var annotation = LazyAnnotations.Value.Annotations.FirstOrDefault(a => a.Name == annotationName);
                return annotation == null ? null : annotation.Value;
            }
        }
    }
}