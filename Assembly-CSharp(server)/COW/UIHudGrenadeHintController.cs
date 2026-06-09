using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018D6 RID: 6358
	[Token(Token = "0x20018D6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4F9C", Offset = "0x10F4F9C")]
	internal class UIHudGrenadeHintController : UIBaseController
	{
		// Token: 0x06007ECB RID: 32459 RVA: 0x00022A58 File Offset: 0x00020C58
		[Token(Token = "0x6007ECB")]
		[Address(RVA = "0x197B27C", Offset = "0x197B27C", VA = "0x7BBC17B27C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007ECC RID: 32460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ECC")]
		[Address(RVA = "0x197B2CC", Offset = "0x197B2CC", VA = "0x7BBC17B2CC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007ECD RID: 32461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ECD")]
		[Address(RVA = "0x197B4D0", Offset = "0x197B4D0", VA = "0x7BBC17B4D0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007ECE RID: 32462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ECE")]
		[Address(RVA = "0x197B59C", Offset = "0x197B59C", VA = "0x7BBC17B59C")]
		private void OnOtherTrigger(params object[] param)
		{
		}

		// Token: 0x06007ECF RID: 32463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ECF")]
		[Address(RVA = "0x197B7D4", Offset = "0x197B7D4", VA = "0x7BBC17B7D4", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007ED0 RID: 32464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ED0")]
		[Address(RVA = "0x197B7FC", Offset = "0x197B7FC", VA = "0x7BBC17B7FC")]
		private void ClearAllHints()
		{
		}

		// Token: 0x06007ED1 RID: 32465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ED1")]
		[Address(RVA = "0x197B96C", Offset = "0x197B96C", VA = "0x7BBC17B96C")]
		private void RefreshGrenadeLocations()
		{
		}

		// Token: 0x06007ED2 RID: 32466 RVA: 0x00022A70 File Offset: 0x00020C70
		[Token(Token = "0x6007ED2")]
		[Address(RVA = "0x197C868", Offset = "0x197C868", VA = "0x7BBC17C868")]
		private bool IsInLandmineRange(LevelLandmine landmine)
		{
			return default(bool);
		}

		// Token: 0x06007ED3 RID: 32467 RVA: 0x00022A88 File Offset: 0x00020C88
		[Token(Token = "0x6007ED3")]
		[Address(RVA = "0x197C4E8", Offset = "0x197C4E8", VA = "0x7BBC17C4E8")]
		private bool ShouldShowHint(Player val)
		{
			return default(bool);
		}

		// Token: 0x06007ED4 RID: 32468 RVA: 0x00022AA0 File Offset: 0x00020CA0
		[Token(Token = "0x6007ED4")]
		[Address(RVA = "0x197C10C", Offset = "0x197C10C", VA = "0x7BBC17C10C")]
		private bool ShouldShowHint(BaseLevelObject val)
		{
			return default(bool);
		}

		// Token: 0x06007ED5 RID: 32469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ED5")]
		[Address(RVA = "0x197CA34", Offset = "0x197CA34", VA = "0x7BBC17CA34")]
		private void LateUpdate()
		{
		}

		// Token: 0x06007ED6 RID: 32470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ED6")]
		[Address(RVA = "0x197D0E8", Offset = "0x197D0E8", VA = "0x7BBC17D0E8")]
		public UIHudGrenadeHintController()
		{
		}

		// Token: 0x040091FC RID: 37372
		[Token(Token = "0x40091FC")]
		[FieldOffset(Offset = "0x58")]
		private UIHudGrenadeHintView m_View;

		// Token: 0x040091FD RID: 37373
		[Token(Token = "0x40091FD")]
		[FieldOffset(Offset = "0x60")]
		private List<UIHudGrenadeHintController.GrenadeLocationData> m_GrenadeLocationData;

		// Token: 0x040091FE RID: 37374
		[Token(Token = "0x40091FE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float WARNING_RATIO;

		// Token: 0x040091FF RID: 37375
		[Token(Token = "0x40091FF")]
		[FieldOffset(Offset = "0x68")]
		private List<UIHudGrenadeSubHintController> m_hintlist;

		// Token: 0x04009200 RID: 37376
		[Token(Token = "0x4009200")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int POOLCOUNT;

		// Token: 0x04009201 RID: 37377
		[Token(Token = "0x4009201")]
		[FieldOffset(Offset = "0x70")]
		private List<{QAb\u0082~u> m_TriggerGrenadedPlayers;

		// Token: 0x020018D7 RID: 6359
		[Token(Token = "0x20018D7")]
		public enum HintType
		{
			// Token: 0x04009203 RID: 37379
			[Token(Token = "0x4009203")]
			GrenaeHint,
			// Token: 0x04009204 RID: 37380
			[Token(Token = "0x4009204")]
			LandmineHint,
			// Token: 0x04009205 RID: 37381
			[Token(Token = "0x4009205")]
			FlashHint
		}

		// Token: 0x020018D8 RID: 6360
		[Token(Token = "0x20018D8")]
		private struct GrenadeLocationData
		{
			// Token: 0x04009206 RID: 37382
			[Token(Token = "0x4009206")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 location;

			// Token: 0x04009207 RID: 37383
			[Token(Token = "0x4009207")]
			[FieldOffset(Offset = "0xC")]
			public UIHudGrenadeHintController.HintType hint;
		}
	}
}
