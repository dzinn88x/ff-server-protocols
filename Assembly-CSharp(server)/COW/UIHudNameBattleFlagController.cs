using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001919 RID: 6425
	[Token(Token = "0x2001919")]
	public class UIHudNameBattleFlagController : UIHudNameBaseController
	{
		// Token: 0x0600819E RID: 33182 RVA: 0x000234D8 File Offset: 0x000216D8
		[Token(Token = "0x600819E")]
		[Address(RVA = "0x17B7258", Offset = "0x17B7258", VA = "0x7BBBFB7258")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600819F RID: 33183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600819F")]
		[Address(RVA = "0x17B72A8", Offset = "0x17B72A8", VA = "0x7BBBFB72A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060081A0 RID: 33184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081A0")]
		[Address(RVA = "0x17B7308", Offset = "0x17B7308", VA = "0x7BBBFB7308")]
		public void BindLevelObject(LevelBattleFlag battle_flag)
		{
		}

		// Token: 0x060081A1 RID: 33185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081A1")]
		[Address(RVA = "0x17B73E8", Offset = "0x17B73E8", VA = "0x7BBBFB73E8")]
		public void ClearBind()
		{
		}

		// Token: 0x060081A2 RID: 33186 RVA: 0x000234F0 File Offset: 0x000216F0
		[Token(Token = "0x60081A2")]
		[Address(RVA = "0x17B7460", Offset = "0x17B7460", VA = "0x7BBBFB7460", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060081A3 RID: 33187 RVA: 0x00023508 File Offset: 0x00021708
		[Token(Token = "0x60081A3")]
		[Address(RVA = "0x17B7574", Offset = "0x17B7574", VA = "0x7BBBFB7574", Slot = "29")]
		protected override bool NeedAutoScaleByDistance()
		{
			return default(bool);
		}

		// Token: 0x060081A4 RID: 33188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081A4")]
		[Address(RVA = "0x17B757C", Offset = "0x17B757C", VA = "0x7BBBFB757C")]
		public UIHudNameBattleFlagController()
		{
		}

		// Token: 0x04009348 RID: 37704
		[Token(Token = "0x4009348")]
		[FieldOffset(Offset = "0xA8")]
		private LevelBattleFlag bindedLevelObject;

		// Token: 0x04009349 RID: 37705
		[Token(Token = "0x4009349")]
		[FieldOffset(Offset = "0xB0")]
		private UIHudNameBattleFlagView m_View;
	}
}
