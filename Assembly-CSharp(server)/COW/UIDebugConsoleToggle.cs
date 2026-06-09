using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014E1 RID: 5345
	[Token(Token = "0x20014E1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDB1C", Offset = "0x10EDB1C")]
	public class UIDebugConsoleToggle : UIBaseController, UITable2.IUITable2Item
	{
		// Token: 0x06005B5E RID: 23390 RVA: 0x0001AB08 File Offset: 0x00018D08
		[Token(Token = "0x6005B5E")]
		[Address(RVA = "0x1BB9A08", Offset = "0x1BB9A08", VA = "0x7BBC3B9A08")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005B5F RID: 23391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B5F")]
		[Address(RVA = "0x1BB9A58", Offset = "0x1BB9A58", VA = "0x7BBC3B9A58", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B60")]
		[Address(RVA = "0x1BB9B3C", Offset = "0x1BB9B3C", VA = "0x7BBC3B9B3C", Slot = "28")]
		public object SetTable2ItemData(int index, object data, object viewState)
		{
			return null;
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B61")]
		[Address(RVA = "0x1BB9C5C", Offset = "0x1BB9C5C", VA = "0x7BBC3B9C5C", Slot = "29")]
		public void SetPosition(Vector2 position)
		{
		}

		// Token: 0x06005B62 RID: 23394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B62")]
		[Address(RVA = "0x1BB9D24", Offset = "0x1BB9D24", VA = "0x7BBC3B9D24", Slot = "30")]
		public void SetTable2Visible(bool visible)
		{
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B63")]
		[Address(RVA = "0x1BB9D60", Offset = "0x1BB9D60", VA = "0x7BBC3B9D60")]
		public void OnToggleValueChange()
		{
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B64")]
		[Address(RVA = "0x1BBA55C", Offset = "0x1BBA55C", VA = "0x7BBC3BA55C")]
		public UIDebugConsoleToggle()
		{
		}

		// Token: 0x04007DF7 RID: 32247
		[Token(Token = "0x4007DF7")]
		[FieldOffset(Offset = "0x58")]
		private UIDebugConsoleToggleView m_View;

		// Token: 0x04007DF8 RID: 32248
		[Token(Token = "0x4007DF8")]
		[FieldOffset(Offset = "0x60")]
		private UIDebugConsoleToggle.Data m_Data;

		// Token: 0x04007DF9 RID: 32249
		[Token(Token = "0x4007DF9")]
		[FieldOffset(Offset = "0x68")]
		public UIDebugConsoleToggle.OnRunCmd OnRunCmdHandler;

		// Token: 0x020014E2 RID: 5346
		[Token(Token = "0x20014E2")]
		public class Data
		{
			// Token: 0x06005B65 RID: 23397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B65")]
			[Address(RVA = "0x1BB458C", Offset = "0x1BB458C", VA = "0x7BBC3B458C")]
			public Data()
			{
			}

			// Token: 0x04007DFA RID: 32250
			[Token(Token = "0x4007DFA")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04007DFB RID: 32251
			[Token(Token = "0x4007DFB")]
			[FieldOffset(Offset = "0x18")]
			public string cmd;

			// Token: 0x04007DFC RID: 32252
			[Token(Token = "0x4007DFC")]
			[FieldOffset(Offset = "0x20")]
			public bool defaultValue;
		}

		// Token: 0x020014E3 RID: 5347
		// (Invoke) Token: 0x06005B67 RID: 23399
		[Token(Token = "0x20014E3")]
		public delegate void OnRunCmd(string cmd, bool toggleValue);
	}
}
