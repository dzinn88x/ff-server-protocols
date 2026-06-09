using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020016F7 RID: 5879
	[Token(Token = "0x20016F7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F12AC", Offset = "0x10F12AC")]
	public class UIChatClanContainerController : UIChatBaseContainerController, IUIModelDataChangeObserver
	{
		// Token: 0x06006D2A RID: 27946 RVA: 0x0001EC78 File Offset: 0x0001CE78
		[Token(Token = "0x6006D2A")]
		[Address(RVA = "0x1BE0A24", Offset = "0x1BE0A24", VA = "0x7BBC3E0A24")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D2B")]
		[Address(RVA = "0x1BE0A74", Offset = "0x1BE0A74", VA = "0x7BBC3E0A74", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D2C")]
		[Address(RVA = "0x1BE0C1C", Offset = "0x1BE0C1C", VA = "0x7BBC3E0C1C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D2D")]
		[Address(RVA = "0x1BE0D10", Offset = "0x1BE0D10", VA = "0x7BBC3E0D10", Slot = "28")]
		public override GameObject GetContentNode()
		{
			return null;
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D2E")]
		[Address(RVA = "0x1BE0D3C", Offset = "0x1BE0D3C", VA = "0x7BBC3E0D3C", Slot = "29")]
		public override GameObject GetEmptyNode()
		{
			return null;
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D2F")]
		[Address(RVA = "0x1BE0D68", Offset = "0x1BE0D68", VA = "0x7BBC3E0D68", Slot = "30")]
		public override UIScrollView GetMessageList()
		{
			return null;
		}

		// Token: 0x06006D30 RID: 27952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D30")]
		[Address(RVA = "0x1BE0D94", Offset = "0x1BE0D94", VA = "0x7BBC3E0D94", Slot = "32")]
		public override void RefreshContentNode()
		{
		}

		// Token: 0x06006D31 RID: 27953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D31")]
		[Address(RVA = "0x1BE0F04", Offset = "0x1BE0F04", VA = "0x7BBC3E0F04", Slot = "31")]
		public override void InitWidget(Transform parent)
		{
		}

		// Token: 0x06006D32 RID: 27954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D32")]
		[Address(RVA = "0x1BE0F80", Offset = "0x1BE0F80", VA = "0x7BBC3E0F80")]
		private void OnGotoSearchClanClick()
		{
		}

		// Token: 0x06006D33 RID: 27955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D33")]
		[Address(RVA = "0x1BE0F94", Offset = "0x1BE0F94", VA = "0x7BBC3E0F94")]
		private void OnGotoLuckyBag()
		{
		}

		// Token: 0x06006D34 RID: 27956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D34")]
		[Address(RVA = "0x1BE10A0", Offset = "0x1BE10A0", VA = "0x7BBC3E10A0")]
		private void ShowLuckyBagMessage(ClanLuckyBag lb)
		{
		}

		// Token: 0x06006D35 RID: 27957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D35")]
		[Address(RVA = "0x1BE134C", Offset = "0x1BE134C", VA = "0x7BBC3E134C", Slot = "33")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006D36 RID: 27958 RVA: 0x0001EC90 File Offset: 0x0001CE90
		[Token(Token = "0x6006D36")]
		[Address(RVA = "0x1BE1454", Offset = "0x1BE1454", VA = "0x7BBC3E1454", Slot = "34")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006D37 RID: 27959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D37")]
		[Address(RVA = "0x1BE1498", Offset = "0x1BE1498", VA = "0x7BBC3E1498")]
		public UIChatClanContainerController()
		{
		}

		// Token: 0x06006D38 RID: 27960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D38")]
		[Address(RVA = "0x1BE14A0", Offset = "0x1BE14A0", VA = "0x7BBC3E14A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11412FC", Offset = "0x11412FC")]
		private void <ShowLuckyBagMessage>b__12_0()
		{
		}

		// Token: 0x0400887E RID: 34942
		[Token(Token = "0x400887E")]
		[FieldOffset(Offset = "0x58")]
		private UIChatClanContainerView m_View;

		// Token: 0x0400887F RID: 34943
		[Token(Token = "0x400887F")]
		[FieldOffset(Offset = "0x60")]
		private uint m_HideLuckyBagCallID;
	}
}
