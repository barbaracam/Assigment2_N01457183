using System;
using System.Reflection;

namespace Assigment2_N01457183_BarbaraCam.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}