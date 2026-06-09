using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;
using Spine.Unity;
using UnityEngine;

namespace COW
{
	// Token: 0x020013CA RID: 5066
	[Token(Token = "0x20013CA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBF08", Offset = "0x10EBF08")]
	internal class UISuperFighterMainController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x060052D9 RID: 21209 RVA: 0x00018D50 File Offset: 0x00016F50
		[Token(Token = "0x60052D9")]
		[Address(RVA = "0x1F44644", Offset = "0x1F44644", VA = "0x7BBC744644")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052DA")]
		[Address(RVA = "0x1F44694", Offset = "0x1F44694", VA = "0x7BBC744694", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052DB")]
		[Address(RVA = "0x1F451D4", Offset = "0x1F451D4", VA = "0x7BBC7451D4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052DC")]
		[Address(RVA = "0x1F45518", Offset = "0x1F45518", VA = "0x7BBC745518", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052DD")]
		[Address(RVA = "0x1F45820", Offset = "0x1F45820", VA = "0x7BBC745820")]
		private void SwitchRoundState()
		{
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052DE")]
		[Address(RVA = "0x1F44EF8", Offset = "0x1F44EF8", VA = "0x7BBC744EF8")]
		private void InitVFX()
		{
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052DF")]
		[Address(RVA = "0x1F469C0", Offset = "0x1F469C0", VA = "0x7BBC7469C0")]
		private void PlayVFX(ResourceID resId, Transform container, UISuperFighterMainController.ERoundState curState)
		{
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E0")]
		[Address(RVA = "0x1F4554C", Offset = "0x1F4554C", VA = "0x7BBC74554C")]
		private void SetView()
		{
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E1")]
		[Address(RVA = "0x1F47410", Offset = "0x1F47410", VA = "0x7BBC747410")]
		private void SetTitleView()
		{
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E2")]
		[Address(RVA = "0x1F47510", Offset = "0x1F47510", VA = "0x7BBC747510")]
		private void SetTimeView()
		{
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E3")]
		[Address(RVA = "0x1F47584", Offset = "0x1F47584", VA = "0x7BBC747584")]
		private void SetTokenView()
		{
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E4")]
		[Address(RVA = "0x1F47840", Offset = "0x1F47840", VA = "0x7BBC747840")]
		private void SetBtnPeakDayView()
		{
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E5")]
		[Address(RVA = "0x1F48690", Offset = "0x1F48690", VA = "0x7BBC748690")]
		private void SetPeakDayBubble()
		{
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E6")]
		[Address(RVA = "0x1F4787C", Offset = "0x1F4787C", VA = "0x7BBC74787C")]
		private void SetBtnMissionView()
		{
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E7")]
		[Address(RVA = "0x1F478AC", Offset = "0x1F478AC", VA = "0x7BBC7478AC")]
		private void SetBtnAwardPreviewView()
		{
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E8")]
		[Address(RVA = "0x1F47908", Offset = "0x1F47908", VA = "0x7BBC747908")]
		private void SetBtnWebEventView()
		{
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052E9")]
		[Address(RVA = "0x1F4798C", Offset = "0x1F4798C", VA = "0x7BBC74798C")]
		private void SetFightingStateView()
		{
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052EA")]
		[Address(RVA = "0x1F47D6C", Offset = "0x1F47D6C", VA = "0x7BBC747D6C")]
		private void SetWinRoundView(bool newEnemySpawned = true)
		{
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052EB")]
		[Address(RVA = "0x1F48068", Offset = "0x1F48068", VA = "0x7BBC748068")]
		private void SetSkillBtnsView()
		{
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052EC")]
		[Address(RVA = "0x1F48890", Offset = "0x1F48890", VA = "0x7BBC748890")]
		private void SetSkillBtnView(ELimitedEvent.SuperFighterManner manner, UILabel damageRange, UILabel tokenCnt, UISprite tokenIcon, GameObject btn)
		{
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052ED")]
		[Address(RVA = "0x1F48250", Offset = "0x1F48250", VA = "0x7BBC748250")]
		private void SetSpineView()
		{
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052EE")]
		[Address(RVA = "0x1F468F0", Offset = "0x1F468F0", VA = "0x7BBC7468F0")]
		private void SetErrorView()
		{
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052EF")]
		[Address(RVA = "0x1F48DC0", Offset = "0x1F48DC0", VA = "0x7BBC748DC0")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F0")]
		[Address(RVA = "0x1F48E5C", Offset = "0x1F48E5C", VA = "0x7BBC748E5C")]
		private void OnBtnToken1Click()
		{
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F1")]
		[Address(RVA = "0x1F49178", Offset = "0x1F49178", VA = "0x7BBC749178")]
		private void OnBtnToken2Click()
		{
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F2")]
		[Address(RVA = "0x1F48EBC", Offset = "0x1F48EBC", VA = "0x7BBC748EBC")]
		private void SetTokenTips(uint tokenId, Transform container)
		{
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F3")]
		[Address(RVA = "0x1F495C4", Offset = "0x1F495C4", VA = "0x7BBC7495C4")]
		private void OnBtnRuleClick()
		{
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F4")]
		[Address(RVA = "0x1F49704", Offset = "0x1F49704", VA = "0x7BBC749704")]
		private void OnBtnPeakDayClick()
		{
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F5")]
		[Address(RVA = "0x1F49844", Offset = "0x1F49844", VA = "0x7BBC749844")]
		private void OnBtnMissionClick()
		{
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F6")]
		[Address(RVA = "0x1F49C4C", Offset = "0x1F49C4C", VA = "0x7BBC749C4C")]
		private void OnBtnAwardPreviewClick()
		{
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F7")]
		[Address(RVA = "0x1F49D8C", Offset = "0x1F49D8C", VA = "0x7BBC749D8C")]
		private void OnBtnWebClick()
		{
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F8")]
		[Address(RVA = "0x1F49EA0", Offset = "0x1F49EA0", VA = "0x7BBC749EA0")]
		private void OnBtnSkillClick(ELimitedEvent.SuperFighterManner manner)
		{
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052F9")]
		[Address(RVA = "0x1F4A110", Offset = "0x1F4A110", VA = "0x7BBC74A110")]
		private void ProcessAnimEvt(object[] data)
		{
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052FA")]
		[Address(RVA = "0x1F4AC0C", Offset = "0x1F4AC0C", VA = "0x7BBC74AC0C")]
		private void OnAwardOpened(object[] data)
		{
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052FB")]
		[Address(RVA = "0x1F4AC18", Offset = "0x1F4AC18", VA = "0x7BBC74AC18")]
		private void AwardWndFinished(object[] data)
		{
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052FC")]
		[Address(RVA = "0x1F4AC3C", Offset = "0x1F4AC3C", VA = "0x7BBC74AC3C")]
		private void RefreshNewFightState()
		{
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052FD")]
		[Address(RVA = "0x1F455BC", Offset = "0x1F455BC", VA = "0x7BBC7455BC")]
		private void AutoOpenPeakDayWndIfNeed()
		{
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052FE")]
		[Address(RVA = "0x1F450D4", Offset = "0x1F450D4", VA = "0x7BBC7450D4")]
		private void PreloadAwardPreviewBubbleCDN()
		{
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052FF")]
		[Address(RVA = "0x1F4A4D4", Offset = "0x1F4A4D4", VA = "0x7BBC74A4D4")]
		private void PlayAwardPreviewBubble()
		{
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005300")]
		[Address(RVA = "0x1F46CB0", Offset = "0x1F46CB0", VA = "0x7BBC746CB0")]
		private void PlayRoundAnim(UISuperFighterMainController.ERoundState state)
		{
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005301")]
		[Address(RVA = "0x1F48BF0", Offset = "0x1F48BF0", VA = "0x7BBC748BF0")]
		private void PlayIdleAnim(List<SkeletonAnimation> anims)
		{
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005302")]
		[Address(RVA = "0x1F4A860", Offset = "0x1F4A860", VA = "0x7BBC74A860")]
		private void PlayHurtAnim(List<SkeletonAnimation> anims)
		{
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005303")]
		[Address(RVA = "0x1F46E20", Offset = "0x1F46E20", VA = "0x7BBC746E20")]
		private void PlayBleedAnim(UISlider HPSlider, UILabel HPLabel, uint HPOri, uint HPNew, uint HPLimit)
		{
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005304")]
		[Address(RVA = "0x1F4ACE8", Offset = "0x1F4ACE8", VA = "0x7BBC74ACE8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113E39C", Offset = "0x113E39C")]
		private IEnumerator PlayBleedAnim(float duration, float timeStep, UISlider slider, UILabel label, uint oriValue, uint newValue, uint limit)
		{
			return null;
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005305")]
		[Address(RVA = "0x1F46ED4", Offset = "0x1F46ED4", VA = "0x7BBC746ED4")]
		private void PlayInOutAnim(TweenPosition tp, bool isDie)
		{
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005306")]
		[Address(RVA = "0x1F472CC", Offset = "0x1F472CC", VA = "0x7BBC7472CC")]
		private void PlayEnterVFX(GameObject vfx, ref uint delayCall, float duration = 1f)
		{
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005307")]
		[Address(RVA = "0x1F4702C", Offset = "0x1F4702C", VA = "0x7BBC74702C")]
		private void ShowAwardWnd()
		{
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005308")]
		[Address(RVA = "0x1F4AE28", Offset = "0x1F4AE28", VA = "0x7BBC74AE28", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x00018D68 File Offset: 0x00016F68
		[Token(Token = "0x6005309")]
		[Address(RVA = "0x1F4B16C", Offset = "0x1F4B16C", VA = "0x7BBC74B16C", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530A")]
		[Address(RVA = "0x1F4B210", Offset = "0x1F4B210", VA = "0x7BBC74B210")]
		public UISuperFighterMainController()
		{
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530B")]
		[Address(RVA = "0x1F4B7C8", Offset = "0x1F4B7C8", VA = "0x7BBC74B7C8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E400", Offset = "0x113E400")]
		private void <OnUIInit>b__39_0()
		{
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530C")]
		[Address(RVA = "0x1F4B7D0", Offset = "0x1F4B7D0", VA = "0x7BBC74B7D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E410", Offset = "0x113E410")]
		private void <OnUIInit>b__39_1()
		{
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530D")]
		[Address(RVA = "0x1F4B7D8", Offset = "0x1F4B7D8", VA = "0x7BBC74B7D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E420", Offset = "0x113E420")]
		private void <OnUIInit>b__39_2()
		{
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530E")]
		[Address(RVA = "0x1F4B7E0", Offset = "0x1F4B7E0", VA = "0x7BBC74B7E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E430", Offset = "0x113E430")]
		private void <AutoOpenPeakDayWndIfNeed>b__74_0()
		{
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530F")]
		[Address(RVA = "0x1F4B830", Offset = "0x1F4B830", VA = "0x7BBC74B830")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E440", Offset = "0x113E440")]
		private void <PlayAwardPreviewBubble>b__76_0()
		{
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005310")]
		[Address(RVA = "0x1F4B87C", Offset = "0x1F4B87C", VA = "0x7BBC74B87C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E450", Offset = "0x113E450")]
		private void <PlayInOutAnim>b__82_0()
		{
		}

		// Token: 0x0400789C RID: 30876
		[Token(Token = "0x400789C")]
		[FieldOffset(Offset = "0xB0")]
		private UISuperFighterMainView m_View;

		// Token: 0x0400789D RID: 30877
		[Token(Token = "0x400789D")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelSuperFighter m_ModelSuperFighter;

		// Token: 0x0400789E RID: 30878
		[Token(Token = "0x400789E")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x0400789F RID: 30879
		[Token(Token = "0x400789F")]
		[FieldOffset(Offset = "0xC8")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040078A0 RID: 30880
		[Token(Token = "0x40078A0")]
		[FieldOffset(Offset = "0xD0")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x040078A1 RID: 30881
		[Token(Token = "0x40078A1")]
		[FieldOffset(Offset = "0xD8")]
		private UIModelMall m_ModelMall;

		// Token: 0x040078A2 RID: 30882
		[Token(Token = "0x40078A2")]
		[FieldOffset(Offset = "0xE0")]
		private UISuperFighterMainController.ERoundState m_CurRoundState;

		// Token: 0x040078A3 RID: 30883
		[Token(Token = "0x40078A3")]
		[FieldOffset(Offset = "0xE8")]
		private Dictionary<uint, string> m_RoundAnimClipDict;

		// Token: 0x040078A4 RID: 30884
		[Token(Token = "0x40078A4")]
		[FieldOffset(Offset = "0xF0")]
		private Dictionary<uint, string> m_SpineAnimDict;

		// Token: 0x040078A5 RID: 30885
		[Token(Token = "0x40078A5")]
		[FieldOffset(Offset = "0xF8")]
		private List<ResourceID> m_PlayerCloseUpTexList;

		// Token: 0x040078A6 RID: 30886
		[Token(Token = "0x40078A6")]
		[FieldOffset(Offset = "0x100")]
		private List<ResourceID> m_EnemyCloseUpTexList;

		// Token: 0x040078A7 RID: 30887
		[Token(Token = "0x40078A7")]
		[FieldOffset(Offset = "0x108")]
		private List<ResourceID> m_PlayerCloseUpSoundList;

		// Token: 0x040078A8 RID: 30888
		[Token(Token = "0x40078A8")]
		[FieldOffset(Offset = "0x110")]
		private List<ResourceID> m_EnemyCloseUpSoundList;

		// Token: 0x040078A9 RID: 30889
		[Token(Token = "0x40078A9")]
		[FieldOffset(Offset = "0x118")]
		private List<ResourceID> m_PlayerHurtVFXList;

		// Token: 0x040078AA RID: 30890
		[Token(Token = "0x40078AA")]
		[FieldOffset(Offset = "0x120")]
		private List<ResourceID> m_EnemyHurtVFXList;

		// Token: 0x040078AB RID: 30891
		[Token(Token = "0x40078AB")]
		[FieldOffset(Offset = "0x128")]
		private ELimitedEvent.SuperFighterManner m_PlayerSkill;

		// Token: 0x040078AC RID: 30892
		[Token(Token = "0x40078AC")]
		[FieldOffset(Offset = "0x130")]
		private CSSuperFighterAttackRes m_RoundInfo;

		// Token: 0x040078AD RID: 30893
		[Token(Token = "0x40078AD")]
		[FieldOffset(Offset = "0x138")]
		private uint m_PlayerHPOri;

		// Token: 0x040078AE RID: 30894
		[Token(Token = "0x40078AE")]
		[FieldOffset(Offset = "0x13C")]
		private uint m_EnemyHPOri;

		// Token: 0x040078AF RID: 30895
		[Token(Token = "0x40078AF")]
		[FieldOffset(Offset = "0x140")]
		private bool m_AwardOpened;

		// Token: 0x040078B0 RID: 30896
		[Token(Token = "0x40078B0")]
		[FieldOffset(Offset = "0x141")]
		private bool m_StateInfoUpdate;

		// Token: 0x040078B1 RID: 30897
		[Token(Token = "0x40078B1")]
		[FieldOffset(Offset = "0x142")]
		private bool m_EnterAnimFinished;

		// Token: 0x040078B2 RID: 30898
		[Token(Token = "0x40078B2")]
		[FieldOffset(Offset = "0x144")]
		private uint m_HurtAnimDelayCall;

		// Token: 0x040078B3 RID: 30899
		[Token(Token = "0x40078B3")]
		[FieldOffset(Offset = "0x148")]
		private uint m_InOutAnimDelayCall;

		// Token: 0x040078B4 RID: 30900
		[Token(Token = "0x40078B4")]
		[FieldOffset(Offset = "0x14C")]
		private uint m_PlayerEnterDelayCall;

		// Token: 0x040078B5 RID: 30901
		[Token(Token = "0x40078B5")]
		[FieldOffset(Offset = "0x150")]
		private uint m_EnemyEnterDelayCall;

		// Token: 0x040078B6 RID: 30902
		[Token(Token = "0x40078B6")]
		[FieldOffset(Offset = "0x154")]
		private uint m_AwardPreviewBubbleDelayCall;

		// Token: 0x040078B7 RID: 30903
		[Token(Token = "0x40078B7")]
		[FieldOffset(Offset = "0x158")]
		private uint m_AutoPeakDayDelayCall;

		// Token: 0x040078B8 RID: 30904
		[Token(Token = "0x40078B8")]
		[FieldOffset(Offset = "0x15C")]
		private uint m_FightVFXDelayCall;

		// Token: 0x040078B9 RID: 30905
		[Token(Token = "0x40078B9")]
		private const float BLEED_ANIM_DURATION = 0.5f;

		// Token: 0x040078BA RID: 30906
		[Token(Token = "0x40078BA")]
		private const float BLEED_ANIM_TIME_STEP = 0.05f;

		// Token: 0x040078BB RID: 30907
		[Token(Token = "0x40078BB")]
		private const float BIG_AWARD_PREVIEW_BUBBLE_DURATION = 5f;

		// Token: 0x040078BC RID: 30908
		[Token(Token = "0x40078BC")]
		private const uint LABEL_COLOR_TOKEN_ENOUGH = 4294967295U;

		// Token: 0x040078BD RID: 30909
		[Token(Token = "0x40078BD")]
		private const uint LABEL_COLOR_TOKEN_NOT_ENOUGH = 4282657791U;

		// Token: 0x040078BE RID: 30910
		[Token(Token = "0x40078BE")]
		private const string DEFEAT_BOX_SPRITE_NAME = "FF_UI_SuperFighter_box07";

		// Token: 0x040078BF RID: 30911
		[Token(Token = "0x40078BF")]
		private const string BIG_AWARD_SPRITE_NAME = "FF_UI_SuperFighter_box01";

		// Token: 0x020013CB RID: 5067
		[Token(Token = "0x20013CB")]
		private enum ERoundState
		{
			// Token: 0x040078C1 RID: 30913
			[Token(Token = "0x40078C1")]
			Idle,
			// Token: 0x040078C2 RID: 30914
			[Token(Token = "0x40078C2")]
			PlayerAttack,
			// Token: 0x040078C3 RID: 30915
			[Token(Token = "0x40078C3")]
			EnemyHurt,
			// Token: 0x040078C4 RID: 30916
			[Token(Token = "0x40078C4")]
			EnemyAttack,
			// Token: 0x040078C5 RID: 30917
			[Token(Token = "0x40078C5")]
			PlayerHurt,
			// Token: 0x040078C6 RID: 30918
			[Token(Token = "0x40078C6")]
			EnemyDie,
			// Token: 0x040078C7 RID: 30919
			[Token(Token = "0x40078C7")]
			PlayerDie,
			// Token: 0x040078C8 RID: 30920
			[Token(Token = "0x40078C8")]
			VictoryAwardDrop,
			// Token: 0x040078C9 RID: 30921
			[Token(Token = "0x40078C9")]
			DefeatAwardDrop,
			// Token: 0x040078CA RID: 30922
			[Token(Token = "0x40078CA")]
			EnemyRevival,
			// Token: 0x040078CB RID: 30923
			[Token(Token = "0x40078CB")]
			PlayerRevival,
			// Token: 0x040078CC RID: 30924
			[Token(Token = "0x40078CC")]
			ShowAward
		}

		// Token: 0x020013CC RID: 5068
		[Token(Token = "0x20013CC")]
		private enum ESpineAnimState
		{
			// Token: 0x040078CE RID: 30926
			[Token(Token = "0x40078CE")]
			Idle,
			// Token: 0x040078CF RID: 30927
			[Token(Token = "0x40078CF")]
			Hurt
		}

		// Token: 0x020013CD RID: 5069
		[Token(Token = "0x20013CD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EBF40", Offset = "0x10EBF40")]
		private sealed class <>c__DisplayClass44_0
		{
			// Token: 0x06005311 RID: 21265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005311")]
			[Address(RVA = "0x1F47408", Offset = "0x1F47408", VA = "0x7BBC747408")]
			public <>c__DisplayClass44_0()
			{
			}

			// Token: 0x06005312 RID: 21266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005312")]
			[Address(RVA = "0x1F4B918", Offset = "0x1F4B918", VA = "0x7BBC74B918")]
			internal void <PlayVFX>b__0()
			{
			}

			// Token: 0x040078D0 RID: 30928
			[Token(Token = "0x40078D0")]
			[FieldOffset(Offset = "0x10")]
			public Transform container;
		}

		// Token: 0x020013CE RID: 5070
		[Token(Token = "0x20013CE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EBF50", Offset = "0x10EBF50")]
		private sealed class <>c__DisplayClass79_0
		{
			// Token: 0x06005313 RID: 21267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005313")]
			[Address(RVA = "0x1F4ACE0", Offset = "0x1F4ACE0", VA = "0x7BBC74ACE0")]
			public <>c__DisplayClass79_0()
			{
			}

			// Token: 0x06005314 RID: 21268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005314")]
			[Address(RVA = "0x1F4B984", Offset = "0x1F4B984", VA = "0x7BBC74B984")]
			internal void <PlayHurtAnim>b__0()
			{
			}

			// Token: 0x040078D1 RID: 30929
			[Token(Token = "0x40078D1")]
			[FieldOffset(Offset = "0x10")]
			public SkeletonAnimation anim;

			// Token: 0x040078D2 RID: 30930
			[Token(Token = "0x40078D2")]
			[FieldOffset(Offset = "0x18")]
			public UISuperFighterMainController <>4__this;
		}

		// Token: 0x020013CF RID: 5071
		[Token(Token = "0x20013CF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EBF60", Offset = "0x10EBF60")]
		private sealed class <PlayBleedAnim>d__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005315 RID: 21269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005315")]
			[Address(RVA = "0x1F4ADF4", Offset = "0x1F4ADF4", VA = "0x7BBC74ADF4")]
			[DebuggerHidden]
			public <PlayBleedAnim>d__81(int <>1__state)
			{
			}

			// Token: 0x06005316 RID: 21270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005316")]
			[Address(RVA = "0x1F4BA94", Offset = "0x1F4BA94", VA = "0x7BBC74BA94", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005317 RID: 21271 RVA: 0x00018D80 File Offset: 0x00016F80
			[Token(Token = "0x6005317")]
			[Address(RVA = "0x1F4BA98", Offset = "0x1F4BA98", VA = "0x7BBC74BA98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000872 RID: 2162
			// (get) Token: 0x06005318 RID: 21272 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000872")]
			private object Current
			{
				[Token(Token = "0x6005318")]
				[Address(RVA = "0x1F4BD88", Offset = "0x1F4BD88", VA = "0x7BBC74BD88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005319 RID: 21273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005319")]
			[Address(RVA = "0x1F4BD90", Offset = "0x1F4BD90", VA = "0x7BBC74BD90", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000873 RID: 2163
			// (get) Token: 0x0600531A RID: 21274 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000873")]
			private object Current
			{
				[Token(Token = "0x600531A")]
				[Address(RVA = "0x1F4BDF8", Offset = "0x1F4BDF8", VA = "0x7BBC74BDF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040078D3 RID: 30931
			[Token(Token = "0x40078D3")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040078D4 RID: 30932
			[Token(Token = "0x40078D4")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040078D5 RID: 30933
			[Token(Token = "0x40078D5")]
			[FieldOffset(Offset = "0x20")]
			public float duration;

			// Token: 0x040078D6 RID: 30934
			[Token(Token = "0x40078D6")]
			[FieldOffset(Offset = "0x24")]
			public float timeStep;

			// Token: 0x040078D7 RID: 30935
			[Token(Token = "0x40078D7")]
			[FieldOffset(Offset = "0x28")]
			public UISlider slider;

			// Token: 0x040078D8 RID: 30936
			[Token(Token = "0x40078D8")]
			[FieldOffset(Offset = "0x30")]
			public UILabel label;

			// Token: 0x040078D9 RID: 30937
			[Token(Token = "0x40078D9")]
			[FieldOffset(Offset = "0x38")]
			public uint oriValue;

			// Token: 0x040078DA RID: 30938
			[Token(Token = "0x40078DA")]
			[FieldOffset(Offset = "0x3C")]
			public uint newValue;

			// Token: 0x040078DB RID: 30939
			[Token(Token = "0x40078DB")]
			[FieldOffset(Offset = "0x40")]
			public uint limit;

			// Token: 0x040078DC RID: 30940
			[Token(Token = "0x40078DC")]
			[FieldOffset(Offset = "0x44")]
			private float <curTime>5__2;

			// Token: 0x040078DD RID: 30941
			[Token(Token = "0x40078DD")]
			[FieldOffset(Offset = "0x48")]
			private float <curValue>5__3;

			// Token: 0x040078DE RID: 30942
			[Token(Token = "0x40078DE")]
			[FieldOffset(Offset = "0x4C")]
			private float <valuePerStep>5__4;
		}

		// Token: 0x020013D0 RID: 5072
		[Token(Token = "0x20013D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EBF70", Offset = "0x10EBF70")]
		private sealed class <>c__DisplayClass83_0
		{
			// Token: 0x0600531B RID: 21275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600531B")]
			[Address(RVA = "0x1F4AE20", Offset = "0x1F4AE20", VA = "0x7BBC74AE20")]
			public <>c__DisplayClass83_0()
			{
			}

			// Token: 0x0600531C RID: 21276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600531C")]
			[Address(RVA = "0x1F4BA60", Offset = "0x1F4BA60", VA = "0x7BBC74BA60")]
			internal void <PlayEnterVFX>b__0()
			{
			}

			// Token: 0x040078DF RID: 30943
			[Token(Token = "0x40078DF")]
			[FieldOffset(Offset = "0x10")]
			public GameObject vfx;
		}

		// Token: 0x020013D1 RID: 5073
		[Token(Token = "0x20013D1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EBF80", Offset = "0x10EBF80")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600531E RID: 21278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600531E")]
			[Address(RVA = "0x1F4B904", Offset = "0x1F4B904", VA = "0x7BBC74B904")]
			public <>c()
			{
			}

			// Token: 0x0600531F RID: 21279 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600531F")]
			[Address(RVA = "0x1F4B90C", Offset = "0x1F4B90C", VA = "0x7BBC74B90C")]
			internal CommonRewardItemInfo <ShowAwardWnd>b__84_0(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x040078E0 RID: 30944
			[Token(Token = "0x40078E0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UISuperFighterMainController.<>c <>9;

			// Token: 0x040078E1 RID: 30945
			[Token(Token = "0x40078E1")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__84_0;
		}
	}
}
