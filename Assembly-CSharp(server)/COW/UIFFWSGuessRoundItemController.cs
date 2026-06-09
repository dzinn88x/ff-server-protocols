using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200135B RID: 4955
	[Token(Token = "0x200135B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB280", Offset = "0x10EB280")]
	internal class UIFFWSGuessRoundItemController : UIBaseController
	{
		// Token: 0x06004EE4 RID: 20196 RVA: 0x00018108 File Offset: 0x00016308
		[Token(Token = "0x6004EE4")]
		[Address(RVA = "0x2279FB0", Offset = "0x2279FB0", VA = "0x7BBCA79FB0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE5")]
		[Address(RVA = "0x227A000", Offset = "0x227A000", VA = "0x7BBCA7A000", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE6")]
		[Address(RVA = "0x2277254", Offset = "0x2277254", VA = "0x7BBCA77254")]
		public void SetData(uint roundIndex, bool choosing, bool haveGuessed)
		{
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE7")]
		[Address(RVA = "0x227A13C", Offset = "0x227A13C", VA = "0x7BBCA7A13C")]
		private void RefreshView(uint roundIndex, bool choosing, bool haveGuessed)
		{
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE8")]
		[Address(RVA = "0x227A2C0", Offset = "0x227A2C0", VA = "0x7BBCA7A2C0")]
		private void OnClickBtnChooseRound()
		{
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE9")]
		[Address(RVA = "0x227A404", Offset = "0x227A404", VA = "0x7BBCA7A404")]
		public UIFFWSGuessRoundItemController()
		{
		}

		// Token: 0x040075F9 RID: 30201
		[Token(Token = "0x40075F9")]
		[FieldOffset(Offset = "0x58")]
		private UIFFWSGuessRoundItemView m_View;

		// Token: 0x040075FA RID: 30202
		[Token(Token = "0x40075FA")]
		[FieldOffset(Offset = "0x60")]
		private uint m_RoundIndex;

		// Token: 0x040075FB RID: 30203
		[Token(Token = "0x40075FB")]
		[FieldOffset(Offset = "0x68")]
		private UIModelFFWS m_ModelFFWS;
	}
}
