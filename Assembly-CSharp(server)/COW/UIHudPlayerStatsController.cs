using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001932 RID: 6450
	[Token(Token = "0x2001932")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5BCC", Offset = "0x10F5BCC")]
	internal class UIHudPlayerStatsController : UIBaseController
	{
		// Token: 0x0600827D RID: 33405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600827D")]
		[Address(RVA = "0x1D7CD1C", Offset = "0x1D7CD1C", VA = "0x7BBC57CD1C")]
		private void OnMedkitHpChange(params object[] data)
		{
		}

		// Token: 0x0600827E RID: 33406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600827E")]
		[Address(RVA = "0x1D7D93C", Offset = "0x1D7D93C", VA = "0x7BBC57D93C")]
		private void OnMushRoomDataChange(params object[] data)
		{
		}

		// Token: 0x0600827F RID: 33407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600827F")]
		[Address(RVA = "0x1D7D9E0", Offset = "0x1D7D9E0", VA = "0x7BBC57D9E0")]
		private void OnMushRoomEpChange(params object[] data)
		{
		}

		// Token: 0x06008280 RID: 33408 RVA: 0x000237F0 File Offset: 0x000219F0
		[Token(Token = "0x6008280")]
		[Address(RVA = "0x1D7E3D0", Offset = "0x1D7E3D0", VA = "0x7BBC57E3D0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008281 RID: 33409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008281")]
		[Address(RVA = "0x1D7E420", Offset = "0x1D7E420", VA = "0x7BBC57E420", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008282 RID: 33410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008282")]
		[Address(RVA = "0x1D7E860", Offset = "0x1D7E860", VA = "0x7BBC57E860", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008283 RID: 33411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008283")]
		[Address(RVA = "0x1D7F6E4", Offset = "0x1D7F6E4", VA = "0x7BBC57F6E4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008284 RID: 33412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008284")]
		[Address(RVA = "0x1D802B0", Offset = "0x1D802B0", VA = "0x7BBC5802B0")]
		public void OnSkillBrightAnim(params object[] data)
		{
		}

		// Token: 0x06008285 RID: 33413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008285")]
		[Address(RVA = "0x1D80484", Offset = "0x1D80484", VA = "0x7BBC580484")]
		public void OnSkillFlashAnim(params object[] data)
		{
		}

		// Token: 0x06008286 RID: 33414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008286")]
		[Address(RVA = "0x1D80620", Offset = "0x1D80620", VA = "0x7BBC580620")]
		public void OnSkillCoolDownAnim(params object[] data)
		{
		}

		// Token: 0x06008287 RID: 33415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008287")]
		[Address(RVA = "0x1D80830", Offset = "0x1D80830", VA = "0x7BBC580830")]
		public void OnMarkedByPetSkillCuringEnemy(params object[] data)
		{
		}

		// Token: 0x06008288 RID: 33416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008288")]
		[Address(RVA = "0x1D80210", Offset = "0x1D80210", VA = "0x7BBC580210")]
		private void CancelDelayCall()
		{
		}

		// Token: 0x06008289 RID: 33417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008289")]
		[Address(RVA = "0x1D809E0", Offset = "0x1D809E0", VA = "0x7BBC5809E0", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600828A RID: 33418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600828A")]
		[Address(RVA = "0x1D80A08", Offset = "0x1D80A08", VA = "0x7BBC580A08")]
		private void HideCuringEnemy()
		{
		}

		// Token: 0x0600828B RID: 33419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600828B")]
		[Address(RVA = "0x1D80A60", Offset = "0x1D80A60", VA = "0x7BBC580A60")]
		private void OnLifeCountChanged(params object[] data)
		{
		}

		// Token: 0x0600828C RID: 33420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600828C")]
		[Address(RVA = "0x1D80BA0", Offset = "0x1D80BA0", VA = "0x7BBC580BA0")]
		private void RefreshLifeCount()
		{
		}

		// Token: 0x0600828D RID: 33421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600828D")]
		[Address(RVA = "0x1D80D2C", Offset = "0x1D80D2C", VA = "0x7BBC580D2C")]
		private void OnAPChanged(params object[] data)
		{
		}

		// Token: 0x0600828E RID: 33422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600828E")]
		[Address(RVA = "0x1D80FAC", Offset = "0x1D80FAC", VA = "0x7BBC580FAC")]
		private void OnMAXChanged(params object[] data)
		{
		}

		// Token: 0x0600828F RID: 33423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600828F")]
		[Address(RVA = "0x1D80E6C", Offset = "0x1D80E6C", VA = "0x7BBC580E6C")]
		private void RefreshAP()
		{
		}

		// Token: 0x06008290 RID: 33424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008290")]
		[Address(RVA = "0x1D810EC", Offset = "0x1D810EC", VA = "0x7BBC5810EC")]
		private void RefreshAPIcon()
		{
		}

		// Token: 0x06008291 RID: 33425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008291")]
		[Address(RVA = "0x1D81540", Offset = "0x1D81540", VA = "0x7BBC581540")]
		private void OnExtraLifeObsoleted(params object[] data)
		{
		}

		// Token: 0x06008292 RID: 33426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008292")]
		[Address(RVA = "0x1D815E0", Offset = "0x1D815E0", VA = "0x7BBC5815E0")]
		private void OnIntroInfoChange(params object[] data)
		{
		}

		// Token: 0x06008293 RID: 33427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008293")]
		[Address(RVA = "0x1D81680", Offset = "0x1D81680", VA = "0x7BBC581680")]
		private void OnEnterRebornFinalStage(params object[] data)
		{
		}

		// Token: 0x06008294 RID: 33428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008294")]
		[Address(RVA = "0x1D81684", Offset = "0x1D81684", VA = "0x7BBC581684")]
		public void BindPlayer({QAb\u0082~u pID)
		{
		}

		// Token: 0x06008295 RID: 33429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008295")]
		[Address(RVA = "0x1D81DD0", Offset = "0x1D81DD0", VA = "0x7BBC581DD0")]
		private void OnPlayerPostInit(params object[] data)
		{
		}

		// Token: 0x06008296 RID: 33430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008296")]
		[Address(RVA = "0x1D826C0", Offset = "0x1D826C0", VA = "0x7BBC5826C0")]
		private void OnHPChanged(params object[] data)
		{
		}

		// Token: 0x06008297 RID: 33431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008297")]
		[Address(RVA = "0x1D82808", Offset = "0x1D82808", VA = "0x7BBC582808")]
		private void OnMAXHPChanged(params object[] data)
		{
		}

		// Token: 0x06008298 RID: 33432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008298")]
		[Address(RVA = "0x1D82B98", Offset = "0x1D82B98", VA = "0x7BBC582B98")]
		private void OnEPChanged(params object[] data)
		{
		}

		// Token: 0x06008299 RID: 33433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008299")]
		[Address(RVA = "0x1D7DA98", Offset = "0x1D7DA98", VA = "0x7BBC57DA98")]
		private void RefreshEP()
		{
		}

		// Token: 0x0600829A RID: 33434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600829A")]
		[Address(RVA = "0x1D82948", Offset = "0x1D82948", VA = "0x7BBC582948")]
		private void RefreshMAXHP(params object[] data)
		{
		}

		// Token: 0x0600829B RID: 33435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600829B")]
		[Address(RVA = "0x1D7CEA4", Offset = "0x1D7CEA4", VA = "0x7BBC57CEA4")]
		private void RefreshHP(params object[] data)
		{
		}

		// Token: 0x0600829C RID: 33436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600829C")]
		[Address(RVA = "0x1D82CDC", Offset = "0x1D82CDC", VA = "0x7BBC582CDC")]
		private void OnAddPlayer(params object[] data)
		{
		}

		// Token: 0x0600829D RID: 33437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600829D")]
		[Address(RVA = "0x1D82DC0", Offset = "0x1D82DC0", VA = "0x7BBC582DC0")]
		private void OnObservePlayer(object[] data)
		{
		}

		// Token: 0x0600829E RID: 33438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600829E")]
		[Address(RVA = "0x1D82FC8", Offset = "0x1D82FC8", VA = "0x7BBC582FC8")]
		private void OnRemoveMapMark(object[] data)
		{
		}

		// Token: 0x0600829F RID: 33439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600829F")]
		[Address(RVA = "0x1D831A4", Offset = "0x1D831A4", VA = "0x7BBC5831A4")]
		private void OnUpdateMapMark(object[] data)
		{
		}

		// Token: 0x060082A0 RID: 33440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082A0")]
		[Address(RVA = "0x1D833E0", Offset = "0x1D833E0", VA = "0x7BBC5833E0")]
		private void OnKnockDownFlagChange(object[] data)
		{
		}

		// Token: 0x060082A1 RID: 33441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082A1")]
		[Address(RVA = "0x1D8201C", Offset = "0x1D8201C", VA = "0x7BBC58201C")]
		private void RefreshSkillStatus()
		{
		}

		// Token: 0x060082A2 RID: 33442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082A2")]
		[Address(RVA = "0x1D82540", Offset = "0x1D82540", VA = "0x7BBC582540")]
		private void CheckSkillNeedShowCDAnim()
		{
		}

		// Token: 0x060082A3 RID: 33443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082A3")]
		[Address(RVA = "0x1D8377C", Offset = "0x1D8377C", VA = "0x7BBC58377C")]
		public void CreateHypeModeProcessBar()
		{
		}

		// Token: 0x060082A4 RID: 33444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082A4")]
		[Address(RVA = "0x1D83A70", Offset = "0x1D83A70", VA = "0x7BBC583A70")]
		private void OnTrainingZoneChanged(params object[] param)
		{
		}

		// Token: 0x060082A5 RID: 33445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082A5")]
		[Address(RVA = "0x1D83B2C", Offset = "0x1D83B2C", VA = "0x7BBC583B2C")]
		private void OnShowMushroomEpTutorial(params object[] param)
		{
		}

		// Token: 0x060082A6 RID: 33446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082A6")]
		[Address(RVA = "0x1D83BCC", Offset = "0x1D83BCC", VA = "0x7BBC583BCC")]
		private void OnShowEPChangeTutorial(params object[] param)
		{
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082A7")]
		[Address(RVA = "0x1D83D04", Offset = "0x1D83D04", VA = "0x7BBC583D04")]
		private void OnPetSkillBufferStart(params object[] param)
		{
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082A8")]
		[Address(RVA = "0x1D840A0", Offset = "0x1D840A0", VA = "0x7BBC5840A0")]
		private void OnActiveSkillCountingStart(params object[] param)
		{
		}

		// Token: 0x060082A9 RID: 33449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082A9")]
		[Address(RVA = "0x1D81AF4", Offset = "0x1D81AF4", VA = "0x7BBC581AF4")]
		private void OnPlayerKnockedDownBleedStateChanged(params object[] param)
		{
		}

		// Token: 0x060082AA RID: 33450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082AA")]
		[Address(RVA = "0x1D8427C", Offset = "0x1D8427C", VA = "0x7BBC58427C")]
		private void OnActiveSkillCountingEnd(params object[] param)
		{
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082AB")]
		[Address(RVA = "0x1D83584", Offset = "0x1D83584", VA = "0x7BBC583584")]
		private void UpdateOBActiveSkillIcon(AvatarSkillData data)
		{
		}

		// Token: 0x060082AC RID: 33452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082AC")]
		[Address(RVA = "0x1D84318", Offset = "0x1D84318", VA = "0x7BBC584318")]
		private void OnAndrewSkillEffectCountChange(params object[] data)
		{
		}

		// Token: 0x060082AD RID: 33453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082AD")]
		[Address(RVA = "0x1D84698", Offset = "0x1D84698", VA = "0x7BBC584698")]
		private void OnEnquipmentEquipStateChanged(params object[] InParams)
		{
		}

		// Token: 0x060082AE RID: 33454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082AE")]
		[Address(RVA = "0x1D844F4", Offset = "0x1D844F4", VA = "0x7BBC5844F4")]
		private void RefreshStrengthenArmorUI()
		{
		}

		// Token: 0x060082AF RID: 33455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082AF")]
		[Address(RVA = "0x1D84830", Offset = "0x1D84830", VA = "0x7BBC584830")]
		public UIHudPlayerStatsController()
		{
		}

		// Token: 0x040093BA RID: 37818
		[Token(Token = "0x40093BA")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPlayerStatsView m_View;

		// Token: 0x040093BB RID: 37819
		[Token(Token = "0x40093BB")]
		[FieldOffset(Offset = "0x60")]
		private {QAb\u0082~u m_BindPlayer;

		// Token: 0x040093BC RID: 37820
		[Token(Token = "0x40093BC")]
		[FieldOffset(Offset = "0x78")]
		private Player m_Player;

		// Token: 0x040093BD RID: 37821
		[Token(Token = "0x40093BD")]
		[FieldOffset(Offset = "0x80")]
		private UIModelMatch m_ModelMatch;

		// Token: 0x040093BE RID: 37822
		[Token(Token = "0x40093BE")]
		[FieldOffset(Offset = "0x88")]
		private bool m_IsPlayerDieing;

		// Token: 0x040093BF RID: 37823
		[Token(Token = "0x40093BF")]
		[FieldOffset(Offset = "0x8C")]
		public readonly float ColorPlayerStatsAlpha;

		// Token: 0x040093C0 RID: 37824
		[Token(Token = "0x40093C0")]
		[FieldOffset(Offset = "0x90")]
		public readonly Color ColorDisableEquipmentStat;

		// Token: 0x040093C1 RID: 37825
		[Token(Token = "0x40093C1")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_IsShowMedKitHp;

		// Token: 0x040093C2 RID: 37826
		[Token(Token = "0x40093C2")]
		[FieldOffset(Offset = "0xA4")]
		private int MedKitHp;

		// Token: 0x040093C3 RID: 37827
		[Token(Token = "0x40093C3")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_IsShowMushroomEp;

		// Token: 0x040093C4 RID: 37828
		[Token(Token = "0x40093C4")]
		[FieldOffset(Offset = "0xAC")]
		private int MushroomEp;

		// Token: 0x040093C5 RID: 37829
		[Token(Token = "0x40093C5")]
		[FieldOffset(Offset = "0xB0")]
		private int SkillMaxY;

		// Token: 0x040093C6 RID: 37830
		[Token(Token = "0x40093C6")]
		[FieldOffset(Offset = "0xB4")]
		private int SkillMiddleY;

		// Token: 0x040093C7 RID: 37831
		[Token(Token = "0x40093C7")]
		[FieldOffset(Offset = "0xB8")]
		private int SkillLowY;

		// Token: 0x040093C8 RID: 37832
		[Token(Token = "0x40093C8")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_ShowEp;

		// Token: 0x040093C9 RID: 37833
		[Token(Token = "0x40093C9")]
		[FieldOffset(Offset = "0xBD")]
		private bool m_InHypeMode;

		// Token: 0x040093CA RID: 37834
		[Token(Token = "0x40093CA")]
		[FieldOffset(Offset = "0xC0")]
		private float m_LastEffectTime;

		// Token: 0x040093CB RID: 37835
		[Token(Token = "0x40093CB")]
		[FieldOffset(Offset = "0xC4")]
		private float m_EffectAnimationTime;

		// Token: 0x040093CC RID: 37836
		[Token(Token = "0x40093CC")]
		[FieldOffset(Offset = "0xC8")]
		private uint m_DelayCallID;

		// Token: 0x040093CD RID: 37837
		[Token(Token = "0x40093CD")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<string, UIHudSkillTemplateController> m_SkillDict;

		// Token: 0x040093CE RID: 37838
		[Token(Token = "0x40093CE")]
		[FieldOffset(Offset = "0xD8")]
		private List<UIHudPetSkillBufferController> m_PetSkillUIs;

		// Token: 0x040093CF RID: 37839
		[Token(Token = "0x40093CF")]
		[FieldOffset(Offset = "0xE0")]
		private UIHudSkillEffectCountingController m_ActiveSkillCountingCtrl;

		// Token: 0x040093D0 RID: 37840
		[Token(Token = "0x40093D0")]
		[FieldOffset(Offset = "0xE8")]
		private UIHudSkillTemplateController m_OBActiveSkillCtrl;

		// Token: 0x040093D1 RID: 37841
		[Token(Token = "0x40093D1")]
		[FieldOffset(Offset = "0xF0")]
		private UIHudSkillKnockDownBleedController m_KnockedDownBleedCtrl;

		// Token: 0x040093D2 RID: 37842
		[Token(Token = "0x40093D2")]
		[FieldOffset(Offset = "0xF8")]
		private UIHudSkillStrengthenArmorController m_StrengthenArmorCtrl;

		// Token: 0x040093D3 RID: 37843
		[Token(Token = "0x40093D3")]
		[FieldOffset(Offset = "0x100")]
		private UIHudPlayerArmorStatsController m_PlayerArmorStatsCtrl;

		// Token: 0x040093D4 RID: 37844
		[Token(Token = "0x40093D4")]
		[FieldOffset(Offset = "0x108")]
		private Color ARMORCOLOR;

		// Token: 0x040093D5 RID: 37845
		[Token(Token = "0x40093D5")]
		[FieldOffset(Offset = "0x118")]
		private Color LIFECOLOR;

		// Token: 0x02001933 RID: 6451
		[Token(Token = "0x2001933")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F5C04", Offset = "0x10F5C04")]
		private sealed class <>c__DisplayClass70_0
		{
			// Token: 0x060082B0 RID: 33456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60082B0")]
			[Address(RVA = "0x1D84098", Offset = "0x1D84098", VA = "0x7BBC584098")]
			public <>c__DisplayClass70_0()
			{
			}

			// Token: 0x060082B1 RID: 33457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60082B1")]
			[Address(RVA = "0x1D849D4", Offset = "0x1D849D4", VA = "0x7BBC5849D4")]
			internal void <OnPetSkillBufferStart>b__0()
			{
			}

			// Token: 0x040093D6 RID: 37846
			[Token(Token = "0x40093D6")]
			[FieldOffset(Offset = "0x10")]
			public UIHudPetSkillBufferController petSkillBuffer;

			// Token: 0x040093D7 RID: 37847
			[Token(Token = "0x40093D7")]
			[FieldOffset(Offset = "0x18")]
			public UIHudPlayerStatsController <>4__this;
		}
	}
}
