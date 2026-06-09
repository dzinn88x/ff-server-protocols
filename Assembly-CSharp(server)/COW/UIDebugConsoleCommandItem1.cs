using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014D4 RID: 5332
	[Token(Token = "0x20014D4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDA7C", Offset = "0x10EDA7C")]
	public class UIDebugConsoleCommandItem1 : UIBaseController, UITable2.IUITable2Item
	{
		// Token: 0x06005B0A RID: 23306 RVA: 0x0001AA90 File Offset: 0x00018C90
		[Token(Token = "0x6005B0A")]
		[Address(RVA = "0x1BB10C0", Offset = "0x1BB10C0", VA = "0x7BBC3B10C0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005B0B RID: 23307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B0B")]
		[Address(RVA = "0x1BB1110", Offset = "0x1BB1110", VA = "0x7BBC3B1110", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005B0C RID: 23308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B0C")]
		[Address(RVA = "0x1BB11F4", Offset = "0x1BB11F4", VA = "0x7BBC3B11F4", Slot = "28")]
		public object SetTable2ItemData(int index, object data, object viewState)
		{
			return null;
		}

		// Token: 0x06005B0D RID: 23309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B0D")]
		[Address(RVA = "0x1BB1358", Offset = "0x1BB1358", VA = "0x7BBC3B1358", Slot = "29")]
		public void SetPosition(Vector2 position)
		{
		}

		// Token: 0x06005B0E RID: 23310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B0E")]
		[Address(RVA = "0x1BB1420", Offset = "0x1BB1420", VA = "0x7BBC3B1420", Slot = "30")]
		public void SetTable2Visible(bool visible)
		{
		}

		// Token: 0x06005B0F RID: 23311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B0F")]
		[Address(RVA = "0x1BB145C", Offset = "0x1BB145C", VA = "0x7BBC3B145C")]
		private void OnCmdClick()
		{
		}

		// Token: 0x06005B10 RID: 23312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B10")]
		[Address(RVA = "0x1BB1C58", Offset = "0x1BB1C58", VA = "0x7BBC3B1C58")]
		public UIDebugConsoleCommandItem1()
		{
		}

		// Token: 0x04007DBB RID: 32187
		[Token(Token = "0x4007DBB")]
		[FieldOffset(Offset = "0x58")]
		private UIDebugConsoleCommandItem1View m_View;

		// Token: 0x04007DBC RID: 32188
		[Token(Token = "0x4007DBC")]
		[FieldOffset(Offset = "0x60")]
		private UIDebugConsoleCommandItem1.Data m_Data;

		// Token: 0x04007DBD RID: 32189
		[Token(Token = "0x4007DBD")]
		[FieldOffset(Offset = "0x68")]
		public UIDebugConsoleCommandItem1.OnRunCmd OnRunCmdHandler;

		// Token: 0x020014D5 RID: 5333
		[Token(Token = "0x20014D5")]
		public class Data
		{
			// Token: 0x06005B11 RID: 23313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B11")]
			[Address(RVA = "0x1BB1C60", Offset = "0x1BB1C60", VA = "0x7BBC3B1C60")]
			public Data()
			{
			}

			// Token: 0x04007DBE RID: 32190
			[Token(Token = "0x4007DBE")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04007DBF RID: 32191
			[Token(Token = "0x4007DBF")]
			[FieldOffset(Offset = "0x18")]
			public string cmd;

			// Token: 0x04007DC0 RID: 32192
			[Token(Token = "0x4007DC0")]
			[FieldOffset(Offset = "0x20")]
			public string argName;

			// Token: 0x04007DC1 RID: 32193
			[Token(Token = "0x4007DC1")]
			[FieldOffset(Offset = "0x28")]
			public string argValue;
		}

		// Token: 0x020014D6 RID: 5334
		// (Invoke) Token: 0x06005B13 RID: 23315
		[Token(Token = "0x20014D6")]
		public delegate void OnRunCmd(string cmd, string arg);
	}
}
