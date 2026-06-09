using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001901 RID: 6401
	[Token(Token = "0x2001901")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F562C", Offset = "0x10F562C")]
	internal class UIHudManualTipsController : UIBaseController
	{
		// Token: 0x06008091 RID: 32913 RVA: 0x000230E8 File Offset: 0x000212E8
		[Token(Token = "0x6008091")]
		[Address(RVA = "0x15BCC94", Offset = "0x15BCC94", VA = "0x7BBBDBCC94")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008092 RID: 32914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008092")]
		[Address(RVA = "0x15BCCE4", Offset = "0x15BCCE4", VA = "0x7BBBDBCCE4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008093 RID: 32915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008093")]
		[Address(RVA = "0x15BCE0C", Offset = "0x15BCE0C", VA = "0x7BBBDBCE0C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008094")]
		[Address(RVA = "0x15BCF68", Offset = "0x15BCF68", VA = "0x7BBBDBCF68")]
		private void ShowTips()
		{
		}

		// Token: 0x06008095 RID: 32917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008095")]
		[Address(RVA = "0x15BD098", Offset = "0x15BD098", VA = "0x7BBBDBD098")]
		private void HideTips()
		{
		}

		// Token: 0x06008096 RID: 32918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008096")]
		[Address(RVA = "0x15BD0D0", Offset = "0x15BD0D0", VA = "0x7BBBDBD0D0")]
		public void SetData(string content)
		{
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008097")]
		[Address(RVA = "0x15BCE34", Offset = "0x15BCE34", VA = "0x7BBBDBCE34")]
		public void ClearData()
		{
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008098")]
		[Address(RVA = "0x15BD300", Offset = "0x15BD300", VA = "0x7BBBDBD300")]
		public UIHudManualTipsController()
		{
		}

		// Token: 0x040092B7 RID: 37559
		[Token(Token = "0x40092B7")]
		[FieldOffset(Offset = "0x58")]
		private UIHudManualTipsView m_View;

		// Token: 0x040092B8 RID: 37560
		[Token(Token = "0x40092B8")]
		[FieldOffset(Offset = "0x60")]
		private TweenAlpha m_FadeInAlpha;

		// Token: 0x040092B9 RID: 37561
		[Token(Token = "0x40092B9")]
		[FieldOffset(Offset = "0x68")]
		private TweenAlpha m_FadeOutAlpha;

		// Token: 0x040092BA RID: 37562
		[Token(Token = "0x40092BA")]
		[FieldOffset(Offset = "0x70")]
		private uint m_ShowDelayCallID;

		// Token: 0x040092BB RID: 37563
		[Token(Token = "0x40092BB")]
		[FieldOffset(Offset = "0x74")]
		private uint m_HideDelayCallID;

		// Token: 0x040092BC RID: 37564
		[Token(Token = "0x40092BC")]
		[FieldOffset(Offset = "0x78")]
		private float m_ShowTime;
	}
}
