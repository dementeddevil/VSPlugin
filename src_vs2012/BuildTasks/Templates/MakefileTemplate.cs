﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace BlackBerry.BuildTasks.Templates
{
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    internal partial class MakefileTemplate : MakefileTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("#\r\n# Makefile for [");
            
            #line 5 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SolutionName));
            
            #line default
            #line hidden
            this.Write("] created at [");
            
            #line 5 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DateTime.Now));
            
            #line default
            #line hidden
            this.Write("] by BlackBerry NDK plugin for Visual Studio (v");
            
            #line 5 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Version));
            
            #line default
            #line hidden
            this.Write(@").
# Any manual changes made by user will be overwritten! Use the project settings instead.
#

#############################################
# Initials
RM := rm -rf

# Empty variable definitions.
O_SRCS :=
CPP_SRCS :=
C_UPPER_SRCS :=
C_SRCS :=
S_UPPER_SRCS :=
OBJ_SRCS :=
II_SRCS :=
ASM_SRCS :=
CXX_SRCS :=
I_SRCS :=
CC_SRCS :=
OBJS :=
C_DEPS :=
CC_DEPS :=
ARCHIVES :=
CPP_DEPS :=
I_DEPS :=
CXX_DEPS :=
C_UPPER_DEPS :=
II_DEPS :=

USER_OBJS :=
LIBS :=

#############################################
# Sources

");
            
            #line 41 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
  if (CompileItemsAsC.Length > 0)
    { 
            
            #line default
            #line hidden
            this.Write("C_SRCS += ");
            
            #line 43 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 Write8Dot3Collection(CompileItemsAsC, "    ", ""); 
            
            #line default
            #line hidden
            this.Write("\r\nC_DEPS += ");
            
            #line 45 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 WriteNameCollection(CompileItemsAsC, "    ./", ".d"); 
            
            #line default
            #line hidden
            
            #line 46 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
  } /* CompileItemsAsC.Length > 0 */ 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 48 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
  if (CompileItemsAsCpp.Length > 0)
    { 
            
            #line default
            #line hidden
            this.Write("CPP_SRCS += ");
            
            #line 50 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 Write8Dot3Collection(CompileItemsAsCpp, "    ", ""); 
            
            #line default
            #line hidden
            this.Write("\r\nCPP_DEPS += ");
            
            #line 52 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 WriteNameCollection(CompileItemsAsCpp, "    ./", ".d"); 
            
            #line default
            #line hidden
            
            #line 53 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
  } /* CompileItemsAsCpp.Length > 0 */ 
            
            #line default
            #line hidden
            this.Write("\r\nOBJS += ");
            
            #line 55 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 WriteNameCollection(CompileItems, "    ./", ".o"); 
            
            #line default
            #line hidden
            this.Write("\r\n#############################################\r\n# Targets\r\n\r\nall: \"");
            
            #line 60 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFile));
            
            #line default
            #line hidden
            this.Write("\"\r\n\r\nDevice-Debug: \"");
            
            #line 62 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFile));
            
            #line default
            #line hidden
            this.Write("\"\r\n\r\nDevice-Release: \"");
            
            #line 64 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFile));
            
            #line default
            #line hidden
            this.Write("\"\r\n\r\nSimulator-Debug: \"");
            
            #line 66 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFile));
            
            #line default
            #line hidden
            this.Write("\"\r\n\r\n\"");
            
            #line 68 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFile));
            
            #line default
            #line hidden
            this.Write("\": $(OBJS) $(USER_OBJS) $(LIB_DEPS)\r\n\t");
            
            #line 69 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 switch (ConfigurationType)
    {
        case "Application":
            {
                // Invoke linker
                
            
            #line default
            #line hidden
            this.Write("qcc -o \"");
            
            #line 74 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OutDir));
            
            #line default
            #line hidden
            
            #line 74 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFile));
            
            #line default
            #line hidden
            this.Write("\" $(OBJS) $(USER_OBJS) $(LIBS) ");
            
            #line 74 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CompilerFlags));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 74 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"


                if (LinkItem.GetMetadata("CompileAs") == "CompileAsC") { 
            
            #line default
            #line hidden
            this.Write("-lang-c ");
            
            #line 76 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("-lang-c++ ");
            
            #line 76 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 }
                if (LinkItem.GetMetadata("GenerateDebugInformation") == "true") { 
            
            #line default
            #line hidden
            this.Write("-g ");
            
            #line 77 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 }

                // For added security, remap some sections of ELF as read-only.
                
            
            #line default
            #line hidden
            this.Write("-Wl,-z,relro,-z,now ");
            
            #line 80 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"


                WriteDependencyLibrariesReferences();
                WriteCollection(GetRootedDirs(ProjectDir, LinkItem.GetMetadata("AdditionalLibraryDirectories").Split(';')), "-L");
                WriteCollection(AdditionalLibraryDirectories, "-L");
            }
            break;
        case "StaticLibrary":
            {
                
            
            #line default
            #line hidden
            this.Write("qcc -A \"");
            
            #line 89 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OutDir));
            
            #line default
            #line hidden
            
            #line 89 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFile));
            
            #line default
            #line hidden
            this.Write(" $(OBJS) $(USER_OBJS) $(LIBS) ");
            
            #line 89 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CompilerFlags));
            
            #line default
            #line hidden
            this.Write(" -w1");
            
            #line 89 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"

            }
            break;
        case "DynamicLibrary":
            {
                // In case of reverse dependencies, may need to add "-Wl,-export-dynamic"
                // Also note that the soname is currently the same as the target name, and no version information is added.
                
            
            #line default
            #line hidden
            this.Write("qcc -shared -Wl,-soname,\"");
            
            #line 96 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFile));
            
            #line default
            #line hidden
            this.Write("\" -o \"");
            
            #line 96 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OutDir));
            
            #line default
            #line hidden
            
            #line 96 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFile));
            
            #line default
            #line hidden
            this.Write("\" $(OBJS) $(USER_OBJS) $(LIBS) ");
            
            #line 96 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CompilerFlags));
            
            #line default
            #line hidden
            
            #line 96 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"

            }
            break;
        default:
            
            
            #line default
            #line hidden
            this.Write("!! Error - unsupported configuration type !!");
            
            #line 100 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"

            break;
    }

            
            #line default
            #line hidden
            this.Write("\r\n\r\nclean: FORCE\r\n\t-$(RM) $(OBJS)$(C_DEPS)$(CC_DEPS)$(COM_QNX_QCC_OUTPUTTYPE_LINK" +
                    "ER_OUTPUTS)$(CPP_DEPS)$(I_DEPS)$(CXX_DEPS)$(C_UPPER_DEPS)$(II_DEPS) \"");
            
            #line 107 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OutDir));
            
            #line default
            #line hidden
            
            #line 107 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetFile));
            
            #line default
            #line hidden
            this.Write("\"");
            
            #line 107 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"

    if (ConfigurationType == "Application")
    {

            
            #line default
            #line hidden
            this.Write(" \"");
            
            #line 110 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OutDir));
            
            #line default
            #line hidden
            
            #line 110 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetBarFile));
            
            #line default
            #line hidden
            this.Write("\"\r\n");
            
            #line 111 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("\r\nFORCE:\r\n\t\r\n\r\n.PHONY: all clean dependents\r\n\r\n");
            
            #line 118 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"


    var warningMap = new Dictionary<string,string>();
    warningMap.Add("TurnOffAllWarnings", "-w0 ");
    warningMap.Add("Level1", "-w1 ");
    warningMap.Add("Level2", "-w2 ");
    warningMap.Add("Level3", "-w3 ");
    warningMap.Add("Level4", "-w4 ");
    warningMap.Add("Level5", "-w5 ");
    warningMap.Add("Level6", "-w6 ");
    warningMap.Add("Level7", "-w7 ");
    warningMap.Add("Level8", "-w8 ");
    warningMap.Add("Level9", "-w9 ");
    warningMap.Add("EnableAllWarnings", "-Wall ");

    foreach(var compileItem in CompileItems)
    {
        var filename = compileItem.GetMetadata("Filename");
        var shortPath = GetFullPath8Dot3(compileItem);

        // Now add a compile rule for this item.
        
            
            #line default
            #line hidden
            
            #line 139 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(filename));
            
            #line default
            #line hidden
            this.Write(".o: ");
            
            #line 139 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(shortPath));
            
            #line default
            #line hidden
            this.Write("\r\n\tqcc -o $@ ");
            
            #line 140 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetFullPath8Dot3(compileItem)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 140 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CompilerFlags));
            
            #line default
            #line hidden
            this.Write(" -c -Wp,-MMD,$(basename $@).d -Wp,-MT,$@ ");
            
            #line 140 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"


        if (compileItem.GetMetadata("CompileAs") == "CompileAsC")
        {
             
            
            #line default
            #line hidden
            this.Write("-lang-c ");
            
            #line 144 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"

        }
        else
        {
            
            
            #line default
            #line hidden
            this.Write("-lang-c++ ");
            
            #line 148 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"

            if (compileItem.GetMetadata("RuntimeTypeInfo") == "false") { 
            
            #line default
            #line hidden
            this.Write("-fno-rtti ");
            
            #line 149 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 }
        }

        string warningLevel;
        if (warningMap.TryGetValue(compileItem.GetMetadata("WarningLevel"), out warningLevel))
        {
            Write(warningLevel);
        }

        if (compileItem.GetMetadata("GenerateDebugInformation") == "true") { 
            
            #line default
            #line hidden
            this.Write("-g ");
            
            #line 158 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 }
        if (compileItem.GetMetadata("GccExceptionHandling") == "true") { 
            
            #line default
            #line hidden
            this.Write("-fexceptions ");
            
            #line 159 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("-fno-exceptions ");
            
            #line 159 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 }
        if (compileItem.GetMetadata("EnhancedSecurity") == "true") { 
            
            #line default
            #line hidden
            this.Write("-fstack-protector-all ");
            
            #line 160 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 }

        // Note: Consider letting user decide between "-fpic" and "-fPIC"
        // For now we use the safe, cross-platform "-fPIC"
        if (ConfigurationType == "DynamicLibrary") { 
            
            #line default
            #line hidden
            this.Write("-fPIC ");
            
            #line 164 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"
 }

        WriteCollection(AdditionalIncludeDirectories, "-I");
        WriteCollection(GetRootedDirs(ProjectDir, compileItem.GetMetadata("AdditionalIncludeDirectories").Replace('\\', '/').Split(';')), "-I");
        WriteCollection(compileItem.GetMetadata("UndefinePreprocessorDefinitions").Split(';'), "-U");
        WriteCollection(compileItem.GetMetadata("PreprocessorDefinitions").Split(';'), "-D");
        Write(compileItem.GetMetadata("AdditionalOptions"));
        
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 174 "T:\vs-plugin\src_vs2012\BuildTasks\Templates\MakefileTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"#############################################
# Include all dependency files

ifneq ($(MAKECMDGOALS),clean)
 ifneq ($(strip $(C_DEPS)),)
  -include $(C_DEPS)
 endif
 ifneq ($(strip $(CC_DEPS)),)
  -include $(CC_DEPS)
 endif
 ifneq ($(strip $(CPP_DEPS)),)
  -include $(CPP_DEPS)
 endif
 ifneq ($(strip $(I_DEPS)),)
  -include $(I_DEPS)
 endif
 ifneq ($(strip $(CXX_DEPS)),)
  -include $(CXX_DEPS)
 endif
 ifneq ($(strip $(C_UPPER_DEPS)),)
  -include $(C_UPPER_DEPS)
 endif
 ifneq ($(strip $(II_DEPS)),)
  -include $(II_DEPS)
 endif
endif

# End
#############################################
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    internal class MakefileTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
