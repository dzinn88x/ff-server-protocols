using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001611 RID: 5649
	[Token(Token = "0x2001611")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF984", Offset = "0x10EF984")]
	internal class UISPHudTeamAccStatsItemController : UIBaseController
	{
		// Token: 0x06006541 RID: 25921 RVA: 0x0001CF98 File Offset: 0x0001B198
		[Token(Token = "0x6006541")]
		[Address(RVA = "0x1EF4374", Offset = "0x1EF4374", VA = "0x7BBC6F4374")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006542 RID: 25922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006542")]
		[Address(RVA = "0x1EF43C4", Offset = "0x1EF43C4", VA = "0x7BBC6F43C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006543 RID: 25923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006543")]
		[Address(RVA = "0x1EF4818", Offset = "0x1EF4818", VA = "0x7BBC6F4818", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006544 RID: 25924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006544")]
		[Address(RVA = "0x1EF48CC", Offset = "0x1EF48CC", VA = "0x7BBC6F48CC")]
		public void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006545 RID: 25925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006545")]
		[Address(RVA = "0x1EF5048", Offset = "0x1EF5048", VA = "0x7BBC6F5048")]
		public void SetUIData(AccTeamData data)
		{
		}

		// Token: 0x06006546 RID: 25926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006546")]
		[Address(RVA = "0x1EF4ED4", Offset = "0x1EF4ED4", VA = "0x7BBC6F4ED4")]
		public void SetLivecountData(AccTeamData data)
		{
		}

		// Token: 0x06006547 RID: 25927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006547")]
		[Address(RVA = "0x1EF504C", Offset = "0x1EF504C", VA = "0x7BBC6F504C")]
		private string GetSpriteNameByNum(uint num)
		{
			return null;
		}

		// Token: 0x06006548 RID: 25928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006548")]
		[Address(RVA = "0x1EF50C8", Offset = "0x1EF50C8", VA = "0x7BBC6F50C8")]
		public UISPHudTeamAccStatsItemController()
		{
		}

		// Token: 0x06006549 RID: 25929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006549")]
		[Address(RVA = "0x1EF5138", Offset = "0x1EF5138", VA = "0x7BBC6F5138")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114051C", Offset = "0x114051C")]
		private void <SetViewData>b__6_0()
		{
		}

		// Token: 0x040083AF RID: 33711
		[Token(Token = "0x40083AF")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudTeamAccStatsItemView m_View;

		// Token: 0x040083B0 RID: 33712
		[Token(Token = "0x40083B0")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallID;

		// Token: 0x040083B1 RID: 33713
		[Token(Token = "0x40083B1")]
		[FieldOffset(Offset = "0x68")]
		private List<UISprite> m_PlayIconList;
	}
}
