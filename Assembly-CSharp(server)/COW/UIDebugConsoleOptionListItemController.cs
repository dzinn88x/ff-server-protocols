using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014E0 RID: 5344
	[Token(Token = "0x20014E0")]
	public class UIDebugConsoleOptionListItemController : UIEasyListItemController
	{
		// Token: 0x06005B59 RID: 23385 RVA: 0x0001AAF0 File Offset: 0x00018CF0
		[Token(Token = "0x6005B59")]
		[Address(RVA = "0x1BB960C", Offset = "0x1BB960C", VA = "0x7BBC3B960C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005B5A RID: 23386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B5A")]
		[Address(RVA = "0x1BB965C", Offset = "0x1BB965C", VA = "0x7BBC3B965C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B5B")]
		[Address(RVA = "0x1BB9740", Offset = "0x1BB9740", VA = "0x7BBC3B9740", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B5C")]
		[Address(RVA = "0x1BB97DC", Offset = "0x1BB97DC", VA = "0x7BBC3B97DC")]
		public UIDebugConsoleOptionListItemController()
		{
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B5D")]
		[Address(RVA = "0x1BB97E4", Offset = "0x1BB97E4", VA = "0x7BBC3B97E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F608", Offset = "0x113F608")]
		private void <OnUIInit>b__4_0()
		{
		}

		// Token: 0x04007DF4 RID: 32244
		[Token(Token = "0x4007DF4")]
		[FieldOffset(Offset = "0x70")]
		public UIDebugConsoleOptionListController OptionListController;

		// Token: 0x04007DF5 RID: 32245
		[Token(Token = "0x4007DF5")]
		[FieldOffset(Offset = "0x78")]
		private UIDebugConsoleOptionListItemView m_View;

		// Token: 0x04007DF6 RID: 32246
		[Token(Token = "0x4007DF6")]
		[FieldOffset(Offset = "0x80")]
		private string m_Option;
	}
}
