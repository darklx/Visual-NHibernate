using ArchAngel.Providers.CodeProvider.DotNet;

namespace ArchAngel.Providers.CodeProvider.VB
{
	class VBEmptyPlaceholderPrinter : IPrinter
	{
		private EmptyPlaceholder obj;

		public VBEmptyPlaceholderPrinter(EmptyPlaceholder obj)
		{
			this.obj = obj;
		}

		public string FullyQualifiedName
		{
			get { throw new System.NotImplementedException(); }
		}

		public string Print()
		{
			throw new System.NotImplementedException();
		}

		public string GetOuterText()
		{
			throw new System.NotImplementedException();
		}

		public string GetInnerText()
		{
			throw new System.NotImplementedException();
		}
	}
}
