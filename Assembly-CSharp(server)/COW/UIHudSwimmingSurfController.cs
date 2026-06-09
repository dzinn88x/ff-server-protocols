using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200196B RID: 6507
	[Token(Token = "0x200196B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6424", Offset = "0x10F6424")]
	internal class UIHudSwimmingSurfController : UIHudButtonBaseController
	{
		// Token: 0x0600845A RID: 33882 RVA: 0x00023EE0 File Offset: 0x000220E0
		[Token(Token = "0x600845A")]
		[Address(RVA = "0x1675E5C", Offset = "0x1675E5C", VA = "0x7BBBE75E5C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600845B RID: 33883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600845B")]
		[Address(RVA = "0x1675EAC", Offset = "0x1675EAC", VA = "0x7BBBE75EAC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600845C RID: 33884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600845C")]
		[Address(RVA = "0x1675FF8", Offset = "0x1675FF8", VA = "0x7BBBE75FF8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600845D RID: 33885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600845D")]
		[Address(RVA = "0x16760C4", Offset = "0x16760C4", VA = "0x7BBBE760C4", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x0600845E RID: 33886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600845E")]
		[Address(RVA = "0x167610C", Offset = "0x167610C", VA = "0x7BBBE7610C")]
		private void Update()
		{
		}

		// Token: 0x0600845F RID: 33887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600845F")]
		[Address(RVA = "0x16762D0", Offset = "0x16762D0", VA = "0x7BBBE762D0")]
		private void OnShowSwimmingSurfHud(params object[] param)
		{
		}

		// Token: 0x06008460 RID: 33888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008460")]
		[Address(RVA = "0x16761DC", Offset = "0x16761DC", VA = "0x7BBBE761DC")]
		private void SetHighLight(bool highlight)
		{
		}

		// Token: 0x06008461 RID: 33889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008461")]
		[Address(RVA = "0x1676378", Offset = "0x1676378", VA = "0x7BBBE76378")]
		public UIHudSwimmingSurfController()
		{
		}

		// Token: 0x040094AF RID: 38063
		[Token(Token = "0x40094AF")]
		[FieldOffset(Offset = "0x60")]
		private UIHudSwimmingSurfView m_View;

		// Token: 0x040094B0 RID: 38064
		[Token(Token = "0x40094B0")]
		private const string SpriteWaterSurfing = "UI_icon_WaterSurfing";

		// Token: 0x040094B1 RID: 38065
		[Token(Token = "0x40094B1")]
		private const string SpriteWaterSurfingHighlight = "UI_icon_WaterSurfing_Choose";

		// Token: 0x040094B2 RID: 38066
		[Token(Token = "0x40094B2")]
		[FieldOffset(Offset = "0x68")]
		private bool mIsHighlight;
	}
}
