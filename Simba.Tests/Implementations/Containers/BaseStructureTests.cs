﻿using Simba.Contracts;
using Simba.Implementations.BaseElements;
using Simba.Implementations.Containers;
using Simba.Tests.Utils;
using Xunit;

namespace Simba.Tests.Implementations.Containers
{
    public class BaseStructureTests
    {
        [Fact]
        public void AddElement_CorrectAddElemntToGroup()
        {
            var container = new StructureMock();
            container.AddElement(new SimpleText("New element"));

            Assert.Equal(1, container.Elements.Count);
        }

        [Fact]
        public void GetLatex_ContainerWithSingleElement_CorrectGenerateLatexCode()
        {
            var container = new StructureMock();
            container.AddElement(new SimpleText("New element"));

            AssertExtensions.CompareLatex(container.GetLatex(),
                                          @"\begin{ContainerBeginValue}
                                                ContainerSeparatorValue
                                                    New element
                                                ContainerSeparatorValue
                                            \end{ContainerEndValue}");
        }


        [Fact]
        public void GetLatex_ContainerWithMultipleElement_CorrectGenerateLatexCode()
        {
            var container = new StructureMock();
            container.AddElement(new SimpleText("New element v1"));
            container.AddElement(new SimpleText("New element v2"));

            AssertExtensions.CompareLatex(container.GetLatex(),
                                           @"\begin{ContainerBeginValue}
                                                ContainerSeparatorValue
                                                    New element v1
                                                ContainerSeparatorValue
                                                    New element v2
                                                ContainerSeparatorValue
                                            \end{ContainerEndValue}");
        }

        private class StructureMock : BaseStructure<ILatexElement>
        {
            protected override string BeginMacroValue => "ContainerBeginValue";
            protected override string EndMacroValue => "ContainerEndValue";
            protected override string ElementSeparatorMacro => "ContainerSeparatorValue";
        }
    }
}