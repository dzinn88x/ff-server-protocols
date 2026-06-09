using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001902 RID: 6402
	[Token(Token = "0x2001902")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5664", Offset = "0x10F5664")]
	public class UIHudMapMarkController : UIHudNameBaseController
	{
		// Token: 0x06008099 RID: 32921 RVA: 0x00023100 File Offset: 0x00021300
		[Token(Token = "0x6008099")]
		[Address(RVA = "0x15BD408", Offset = "0x15BD408", VA = "0x7BBBDBD408")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600809A RID: 32922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600809A")]
		[Address(RVA = "0x15BD458", Offset = "0x15BD458", VA = "0x7BBBDBD458", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600809B RID: 32923 RVA: 0x00023118 File Offset: 0x00021318
		[Token(Token = "0x600809B")]
		[Address(RVA = "0x15BD58C", Offset = "0x15BD58C", VA = "0x7BBBDBD58C", Slot = "32")]
		protected override bool NeedShowDistance()
		{
			return default(bool);
		}

		// Token: 0x0600809C RID: 32924 RVA: 0x00023130 File Offset: 0x00021330
		[Token(Token = "0x600809C")]
		[Address(RVA = "0x15BD594", Offset = "0x15BD594", VA = "0x7BBBDBD594", Slot = "30")]
		protected override bool NeedKeepInScreen()
		{
			return default(bool);
		}

		// Token: 0x0600809D RID: 32925 RVA: 0x00023148 File Offset: 0x00021348
		[Token(Token = "0x600809D")]
		[Address(RVA = "0x15BD59C", Offset = "0x15BD59C", VA = "0x7BBBDBD59C", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x00023160 File Offset: 0x00021360
		[Token(Token = "0x600809E")]
		[Address(RVA = "0x15BD5A8", Offset = "0x15BD5A8", VA = "0x7BBBDBD5A8", Slot = "37")]
		protected override Vector2 GetWidgetBound()
		{
			return default(Vector2);
		}

		// Token: 0x0600809F RID: 32927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600809F")]
		[Address(RVA = "0x15BD5E4", Offset = "0x15BD5E4", VA = "0x7BBBDBD5E4")]
		public void PrepareForClose()
		{
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A0")]
		[Address(RVA = "0x15BD6DC", Offset = "0x15BD6DC", VA = "0x7BBBDBD6DC")]
		private void DelayClose()
		{
		}

		// Token: 0x060080A1 RID: 32929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A1")]
		[Address(RVA = "0x15BD7CC", Offset = "0x15BD7CC", VA = "0x7BBBDBD7CC")]
		public void SetMarkData(Vector3 position, int teamIndex)
		{
		}

		// Token: 0x060080A2 RID: 32930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A2")]
		[Address(RVA = "0x15BD9D0", Offset = "0x15BD9D0", VA = "0x7BBBDBD9D0")]
		public void SetIsLeader(bool leader = false)
		{
		}

		// Token: 0x060080A3 RID: 32931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A3")]
		[Address(RVA = "0x15BD8B8", Offset = "0x15BD8B8", VA = "0x7BBBDBD8B8")]
		private void RefreshMarkIconSprite(UISprite icon, int index)
		{
		}

		// Token: 0x060080A4 RID: 32932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A4")]
		[Address(RVA = "0x15BDA88", Offset = "0x15BDA88", VA = "0x7BBBDBDA88")]
		public UIHudMapMarkController()
		{
		}

		// Token: 0x040092BD RID: 37565
		[Token(Token = "0x40092BD")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudMapMarkView m_View;

		// Token: 0x040092BE RID: 37566
		[Token(Token = "0x40092BE")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 m_MarkPosition;
	}
}
