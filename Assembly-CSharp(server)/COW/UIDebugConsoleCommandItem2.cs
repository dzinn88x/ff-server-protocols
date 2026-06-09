using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014D7 RID: 5335
	[Token(Token = "0x20014D7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDAB4", Offset = "0x10EDAB4")]
	public class UIDebugConsoleCommandItem2 : UIBaseController, UITable2.IUITable2Item
	{
		// Token: 0x06005B16 RID: 23318 RVA: 0x0001AAA8 File Offset: 0x00018CA8
		[Token(Token = "0x6005B16")]
		[Address(RVA = "0x1BB1E28", Offset = "0x1BB1E28", VA = "0x7BBC3B1E28")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005B17 RID: 23319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B17")]
		[Address(RVA = "0x1BB1E78", Offset = "0x1BB1E78", VA = "0x7BBC3B1E78", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005B18 RID: 23320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B18")]
		[Address(RVA = "0x1BB1F5C", Offset = "0x1BB1F5C", VA = "0x7BBC3B1F5C", Slot = "28")]
		public object SetTable2ItemData(int index, object data, object viewState)
		{
			return null;
		}

		// Token: 0x06005B19 RID: 23321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B19")]
		[Address(RVA = "0x1BB20C0", Offset = "0x1BB20C0", VA = "0x7BBC3B20C0", Slot = "29")]
		public void SetPosition(Vector2 position)
		{
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B1A")]
		[Address(RVA = "0x1BB2188", Offset = "0x1BB2188", VA = "0x7BBC3B2188", Slot = "30")]
		public void SetTable2Visible(bool visible)
		{
		}

		// Token: 0x06005B1B RID: 23323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B1B")]
		[Address(RVA = "0x1BB21C4", Offset = "0x1BB21C4", VA = "0x7BBC3B21C4")]
		private void OnCmdClick()
		{
		}

		// Token: 0x06005B1C RID: 23324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B1C")]
		[Address(RVA = "0x1BB2A38", Offset = "0x1BB2A38", VA = "0x7BBC3B2A38")]
		public UIDebugConsoleCommandItem2()
		{
		}

		// Token: 0x04007DC2 RID: 32194
		[Token(Token = "0x4007DC2")]
		[FieldOffset(Offset = "0x58")]
		private UIDebugConsoleCommandItem2View m_View;

		// Token: 0x04007DC3 RID: 32195
		[Token(Token = "0x4007DC3")]
		[FieldOffset(Offset = "0x60")]
		private UIDebugConsoleCommandItem2.Data m_Data;

		// Token: 0x04007DC4 RID: 32196
		[Token(Token = "0x4007DC4")]
		[FieldOffset(Offset = "0x68")]
		public UIDebugConsoleCommandItem2.OnRunCmd OnRunCmdHandler;

		// Token: 0x020014D8 RID: 5336
		[Token(Token = "0x20014D8")]
		public class Data
		{
			// Token: 0x06005B1D RID: 23325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B1D")]
			[Address(RVA = "0x1BB2A40", Offset = "0x1BB2A40", VA = "0x7BBC3B2A40")]
			public Data()
			{
			}

			// Token: 0x04007DC5 RID: 32197
			[Token(Token = "0x4007DC5")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04007DC6 RID: 32198
			[Token(Token = "0x4007DC6")]
			[FieldOffset(Offset = "0x18")]
			public string cmd;

			// Token: 0x04007DC7 RID: 32199
			[Token(Token = "0x4007DC7")]
			[FieldOffset(Offset = "0x20")]
			public string arg1Name;

			// Token: 0x04007DC8 RID: 32200
			[Token(Token = "0x4007DC8")]
			[FieldOffset(Offset = "0x28")]
			public string arg2Name;
		}

		// Token: 0x020014D9 RID: 5337
		// (Invoke) Token: 0x06005B1F RID: 23327
		[Token(Token = "0x20014D9")]
		public delegate void OnRunCmd(string cmd, string arg1, string arg2);
	}
}
