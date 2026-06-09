using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001398 RID: 5016
	[Token(Token = "0x2001398")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB868", Offset = "0x10EB868")]
	internal class UIDiceGameMainController : UINaviPopController, IUIModelDataChangeObserver
	{
		// Token: 0x060050DB RID: 20699 RVA: 0x00018810 File Offset: 0x00016A10
		[Token(Token = "0x60050DB")]
		[Address(RVA = "0x21FAA60", Offset = "0x21FAA60", VA = "0x7BBC9FAA60")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050DC")]
		[Address(RVA = "0x21FAAB0", Offset = "0x21FAAB0", VA = "0x7BBC9FAAB0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x00018828 File Offset: 0x00016A28
		[Token(Token = "0x60050DD")]
		[Address(RVA = "0x21FBA94", Offset = "0x21FBA94", VA = "0x7BBC9FBA94", Slot = "35")]
		public override EFrontendBGMType GetBGMType()
		{
			return EFrontendBGMType.NONE;
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050DE")]
		[Address(RVA = "0x21FBA9C", Offset = "0x21FBA9C", VA = "0x7BBC9FBA9C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050DF")]
		[Address(RVA = "0x21FBE1C", Offset = "0x21FBE1C", VA = "0x7BBC9FBE1C")]
		private void CleanDelayCall()
		{
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E0")]
		[Address(RVA = "0x21FB81C", Offset = "0x21FB81C", VA = "0x7BBC9FB81C")]
		private void InitGlass()
		{
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E1")]
		[Address(RVA = "0x21FB584", Offset = "0x21FB584", VA = "0x7BBC9FB584")]
		private void InitAnimInfo()
		{
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E2")]
		[Address(RVA = "0x21FC014", Offset = "0x21FC014", VA = "0x7BBC9FC014")]
		private void InitGuide()
		{
		}

		// Token: 0x060050E3 RID: 20707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E3")]
		[Address(RVA = "0x21FC4A8", Offset = "0x21FC4A8", VA = "0x7BBC9FC4A8")]
		private void ShowPhaseDialog()
		{
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E4")]
		[Address(RVA = "0x21FC6F0", Offset = "0x21FC6F0", VA = "0x7BBC9FC6F0")]
		private void _ShowPhaseDialog(int phase)
		{
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050E5")]
		[Address(RVA = "0x21FC92C", Offset = "0x21FC92C", VA = "0x7BBC9FC92C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113E00C", Offset = "0x113E00C")]
		private IEnumerator CoTypeDialog(UILabel label, string str)
		{
			return null;
		}

		// Token: 0x060050E6 RID: 20710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E6")]
		[Address(RVA = "0x21FCA08", Offset = "0x21FCA08", VA = "0x7BBC9FCA08")]
		private void OnTypeEnd()
		{
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E7")]
		[Address(RVA = "0x21FC7C8", Offset = "0x21FC7C8", VA = "0x7BBC9FC7C8")]
		private void BeforeType()
		{
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E8")]
		[Address(RVA = "0x21FCB64", Offset = "0x21FCB64", VA = "0x7BBC9FCB64")]
		private void OnClickShowDialogMask()
		{
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E9")]
		[Address(RVA = "0x21FCA9C", Offset = "0x21FCA9C", VA = "0x7BBC9FCA9C")]
		private void SetGlassBgVisible(bool b)
		{
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x00018840 File Offset: 0x00016A40
		[Token(Token = "0x60050EA")]
		[Address(RVA = "0x21FCD50", Offset = "0x21FCD50", VA = "0x7BBC9FCD50")]
		private bool CheckGameAvalible()
		{
			return default(bool);
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050EB")]
		[Address(RVA = "0x21FB7EC", Offset = "0x21FB7EC", VA = "0x7BBC9FB7EC")]
		private void RequestGameConfig()
		{
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050EC")]
		[Address(RVA = "0x21FCD70", Offset = "0x21FCD70", VA = "0x7BBC9FCD70")]
		private void RequestGameInfo()
		{
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050ED")]
		[Address(RVA = "0x21FCDF0", Offset = "0x21FCDF0", VA = "0x7BBC9FCDF0")]
		private void RequestPhaseRwdInfo()
		{
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050EE")]
		[Address(RVA = "0x21FCE20", Offset = "0x21FCE20", VA = "0x7BBC9FCE20")]
		private void RefreshItemsCnt()
		{
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050EF")]
		[Address(RVA = "0x21FD064", Offset = "0x21FD064", VA = "0x7BBC9FD064")]
		private void UpdateDiceCnt(int delta)
		{
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F0")]
		[Address(RVA = "0x21FD170", Offset = "0x21FD170", VA = "0x7BBC9FD170")]
		private void UpdateTokenCnt(int delta)
		{
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F1")]
		[Address(RVA = "0x21FD1EC", Offset = "0x21FD1EC", VA = "0x7BBC9FD1EC")]
		private void InitUIByGameConfig()
		{
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F2")]
		[Address(RVA = "0x21FD8C8", Offset = "0x21FD8C8", VA = "0x7BBC9FD8C8")]
		private void InitPlayerBoardInfo()
		{
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F3")]
		[Address(RVA = "0x21FD994", Offset = "0x21FD994", VA = "0x7BBC9FD994")]
		private void InitBoard()
		{
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F4")]
		[Address(RVA = "0x21FDB58", Offset = "0x21FDB58", VA = "0x7BBC9FDB58")]
		private void FillBoard(bool shouldInitFromConfig)
		{
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F5")]
		[Address(RVA = "0x21FDCC8", Offset = "0x21FDCC8", VA = "0x7BBC9FDCC8")]
		private void OnCloseBtnClick()
		{
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F6")]
		[Address(RVA = "0x21FDD64", Offset = "0x21FDD64", VA = "0x7BBC9FDD64")]
		private void OnRollBtnClick()
		{
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F7")]
		[Address(RVA = "0x21FDFB8", Offset = "0x21FDFB8", VA = "0x7BBC9FDFB8")]
		private void OnRuleBtnClick()
		{
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F8")]
		[Address(RVA = "0x21FE104", Offset = "0x21FE104", VA = "0x7BBC9FE104")]
		private void OnRuleCloseBtnClick()
		{
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F9")]
		[Address(RVA = "0x21FE410", Offset = "0x21FE410", VA = "0x7BBC9FE410")]
		private void OnDiceInfoBtnClick()
		{
		}

		// Token: 0x060050FA RID: 20730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FA")]
		[Address(RVA = "0x21FE664", Offset = "0x21FE664", VA = "0x7BBC9FE664")]
		private void OnTokenInfoBtnClick()
		{
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FB")]
		[Address(RVA = "0x21FE8B8", Offset = "0x21FE8B8", VA = "0x7BBC9FE8B8")]
		private void OnTaskBtnClick()
		{
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FC")]
		[Address(RVA = "0x21FED6C", Offset = "0x21FED6C", VA = "0x7BBC9FED6C")]
		private void OnOpt1Click()
		{
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FD")]
		[Address(RVA = "0x21FEDA0", Offset = "0x21FEDA0", VA = "0x7BBC9FEDA0")]
		private void OnOpt2Click()
		{
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FE")]
		[Address(RVA = "0x21FEDD4", Offset = "0x21FEDD4", VA = "0x7BBC9FEDD4")]
		private void OnCloseTaskClick()
		{
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FF")]
		[Address(RVA = "0x21FF158", Offset = "0x21FF158", VA = "0x7BBC9FF158")]
		private void OnGotoLobbyClick()
		{
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005100")]
		[Address(RVA = "0x21FF2E4", Offset = "0x21FF2E4", VA = "0x7BBC9FF2E4")]
		private void PlayPhaseTweenProgressBar(float from, float to)
		{
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005101")]
		[Address(RVA = "0x21FF330", Offset = "0x21FF330", VA = "0x7BBC9FF330")]
		private void OnPhaseTweenProgressBarEnd()
		{
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x00018858 File Offset: 0x00016A58
		[Token(Token = "0x6005102")]
		[Address(RVA = "0x21FF5A4", Offset = "0x21FF5A4", VA = "0x7BBC9FF5A4")]
		private int GetPlayerCurPhase()
		{
			return 0;
		}

		// Token: 0x06005103 RID: 20739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005103")]
		[Address(RVA = "0x21FF65C", Offset = "0x21FF65C", VA = "0x7BBC9FF65C")]
		private void OnQuestBtnClick()
		{
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005104")]
		[Address(RVA = "0x21FF80C", Offset = "0x21FF80C", VA = "0x7BBC9FF80C")]
		private void OnPlayerGothroughtStartPoint(params object[] data)
		{
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005105")]
		[Address(RVA = "0x21FFC44", Offset = "0x21FFC44", VA = "0x7BBC9FFC44")]
		private void OnGotItemTweenEnd(params object[] data)
		{
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005106")]
		[Address(RVA = "0x21FFC94", Offset = "0x21FFC94", VA = "0x7BBC9FFC94")]
		private void OnAnimEventOccur(params object[] data)
		{
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005107")]
		[Address(RVA = "0x220041C", Offset = "0x220041C", VA = "0x7BBCA0041C")]
		private void OnMVPRwdWndClose(params object[] data)
		{
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005108")]
		[Address(RVA = "0x2200430", Offset = "0x2200430", VA = "0x7BBCA00430")]
		private void OnBranchWndClose(params object[] data)
		{
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005109")]
		[Address(RVA = "0x2200444", Offset = "0x2200444", VA = "0x7BBCA00444")]
		private void OnBoxOpen(params object[] data)
		{
		}

		// Token: 0x0600510A RID: 20746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510A")]
		[Address(RVA = "0x2200448", Offset = "0x2200448", VA = "0x7BBCA00448")]
		private void OnPlayerMoveFinished(params object[] data)
		{
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510B")]
		[Address(RVA = "0x22004D0", Offset = "0x22004D0", VA = "0x7BBCA004D0")]
		private void HandlePlayerMoveEnd()
		{
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510C")]
		[Address(RVA = "0x22017E8", Offset = "0x22017E8", VA = "0x7BBCA017E8")]
		private void HandleChooseEventRes(CSMonopolyEventChooseRes result)
		{
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510D")]
		[Address(RVA = "0x2201B04", Offset = "0x2201B04", VA = "0x7BBCA01B04")]
		private void _DelayCall(float time, Action action)
		{
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510E")]
		[Address(RVA = "0x2200F10", Offset = "0x2200F10", VA = "0x7BBCA00F10")]
		private void ShowRwd(bool isToken, bool isBonus = false, uint cnt = 0U, bool isEvent = false)
		{
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510F")]
		[Address(RVA = "0x21FEC6C", Offset = "0x21FEC6C", VA = "0x7BBC9FEC6C")]
		private void ShowBranchEvent(DiceGameBranchData data)
		{
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005110")]
		[Address(RVA = "0x2201C20", Offset = "0x2201C20", VA = "0x7BBCA01C20")]
		private void SetGameInfo()
		{
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005111")]
		[Address(RVA = "0x2200120", Offset = "0x2200120", VA = "0x7BBCA00120")]
		private void UpdateBuffView(EBuffEffectType t = EBuffEffectType.None)
		{
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005112")]
		[Address(RVA = "0x220158C", Offset = "0x220158C", VA = "0x7BBCA0158C")]
		private void HandleEventBranch()
		{
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005113")]
		[Address(RVA = "0x21FB7C0", Offset = "0x21FB7C0", VA = "0x7BBC9FB7C0")]
		private void InitBaseInfo()
		{
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005114")]
		[Address(RVA = "0x2201D3C", Offset = "0x2201D3C", VA = "0x7BBCA01D3C")]
		private void InitEffect()
		{
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005115")]
		[Address(RVA = "0x2201E10", Offset = "0x2201E10", VA = "0x7BBCA01E10")]
		private void OnDiceAnimMaskClick()
		{
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005116")]
		[Address(RVA = "0x2202128", Offset = "0x2202128", VA = "0x7BBCA02128")]
		private void ProcessRollDiceResult()
		{
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005117")]
		[Address(RVA = "0x220208C", Offset = "0x220208C", VA = "0x7BBCA0208C")]
		private string GetCurDiceRollAnimName()
		{
			return null;
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005118")]
		[Address(RVA = "0x2202394", Offset = "0x2202394", VA = "0x7BBCA02394")]
		private void InitPhaseRwd()
		{
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005119")]
		[Address(RVA = "0x21FF334", Offset = "0x21FF334", VA = "0x7BBC9FF334")]
		private void UpdatePhaseRwdInfo()
		{
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600511A")]
		[Address(RVA = "0x22024E4", Offset = "0x22024E4", VA = "0x7BBCA024E4")]
		private void SetCDN()
		{
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600511B")]
		[Address(RVA = "0x21FEDDC", Offset = "0x21FEDDC", VA = "0x7BBC9FEDDC")]
		private void UpdateTaskInfo(bool isTcpNoti = false)
		{
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x00018870 File Offset: 0x00016A70
		[Token(Token = "0x600511C")]
		[Address(RVA = "0x22025F4", Offset = "0x22025F4", VA = "0x7BBCA025F4", Slot = "41")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600511D")]
		[Address(RVA = "0x2202678", Offset = "0x2202678", VA = "0x7BBCA02678", Slot = "40")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600511E")]
		[Address(RVA = "0x2202A28", Offset = "0x2202A28", VA = "0x7BBCA02A28")]
		public UIDiceGameMainController()
		{
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600511F")]
		[Address(RVA = "0x2202B44", Offset = "0x2202B44", VA = "0x7BBCA02B44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E070", Offset = "0x113E070")]
		private void <InitGuide>b__42_0()
		{
		}

		// Token: 0x06005120 RID: 20768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005120")]
		[Address(RVA = "0x2202BA4", Offset = "0x2202BA4", VA = "0x7BBCA02BA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E080", Offset = "0x113E080")]
		private void <InitGuide>b__42_1()
		{
		}

		// Token: 0x06005121 RID: 20769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005121")]
		[Address(RVA = "0x2202E7C", Offset = "0x2202E7C", VA = "0x7BBCA02E7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E090", Offset = "0x113E090")]
		private void <InitGuide>b__42_3()
		{
		}

		// Token: 0x06005122 RID: 20770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005122")]
		[Address(RVA = "0x2202EDC", Offset = "0x2202EDC", VA = "0x7BBCA02EDC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E0A0", Offset = "0x113E0A0")]
		private void <OnRuleCloseBtnClick>b__71_0()
		{
		}

		// Token: 0x06005123 RID: 20771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005123")]
		[Address(RVA = "0x2202F3C", Offset = "0x2202F3C", VA = "0x7BBCA02F3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E0B0", Offset = "0x113E0B0")]
		private void <OnPlayerGothroughtStartPoint>b__84_0()
		{
		}

		// Token: 0x06005124 RID: 20772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005124")]
		[Address(RVA = "0x22030B8", Offset = "0x22030B8", VA = "0x7BBCA030B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E0C0", Offset = "0x113E0C0")]
		private void <OnPlayerGothroughtStartPoint>b__84_1()
		{
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005125")]
		[Address(RVA = "0x2203168", Offset = "0x2203168", VA = "0x7BBCA03168")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E0D0", Offset = "0x113E0D0")]
		private void <HandlePlayerMoveEnd>b__93_0()
		{
		}

		// Token: 0x06005126 RID: 20774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005126")]
		[Address(RVA = "0x22031D4", Offset = "0x22031D4", VA = "0x7BBCA031D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E0E0", Offset = "0x113E0E0")]
		private void <HandlePlayerMoveEnd>b__93_1()
		{
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005127")]
		[Address(RVA = "0x2203240", Offset = "0x2203240", VA = "0x7BBCA03240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E0F0", Offset = "0x113E0F0")]
		private void <OnDiceAnimMaskClick>b__111_0()
		{
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005128")]
		[Address(RVA = "0x22032E8", Offset = "0x22032E8", VA = "0x7BBCA032E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E100", Offset = "0x113E100")]
		private void <ProcessRollDiceResult>b__112_0()
		{
		}

		// Token: 0x0400776F RID: 30575
		[Token(Token = "0x400776F")]
		[FieldOffset(Offset = "0xB8")]
		private UIDiceGameMainView m_View;

		// Token: 0x04007770 RID: 30576
		[Token(Token = "0x4007770")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelMVP m_ModelMVP;

		// Token: 0x04007771 RID: 30577
		[Token(Token = "0x4007771")]
		[FieldOffset(Offset = "0xC8")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x04007772 RID: 30578
		[Token(Token = "0x4007772")]
		[FieldOffset(Offset = "0xD0")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x04007773 RID: 30579
		[Token(Token = "0x4007773")]
		[FieldOffset(Offset = "0xD8")]
		private List<UIDiceGameGridItemController> m_DiceGridItems;

		// Token: 0x04007774 RID: 30580
		[Token(Token = "0x4007774")]
		[FieldOffset(Offset = "0xE0")]
		private List<UIDiceGameGridWayPoint> m_WayPoints;

		// Token: 0x04007775 RID: 30581
		[Token(Token = "0x4007775")]
		[FieldOffset(Offset = "0xE8")]
		private DiceGamePlayerController m_Player;

		// Token: 0x04007776 RID: 30582
		[Token(Token = "0x4007776")]
		[FieldOffset(Offset = "0xF0")]
		private List<UIStandardItemMiniController> m_CacheRwdItems;

		// Token: 0x04007777 RID: 30583
		[Token(Token = "0x4007777")]
		[FieldOffset(Offset = "0xF8")]
		private List<DiceGamePhaseRwdItemController> m_PhaseRwdItems;

		// Token: 0x04007778 RID: 30584
		[Token(Token = "0x4007778")]
		[FieldOffset(Offset = "0x100")]
		private float m_DiceRollAnimPlayTime;

		// Token: 0x04007779 RID: 30585
		[Token(Token = "0x4007779")]
		private const string ROLLDICEANIM_NAME = "Dice_Ani0";

		// Token: 0x0400777A RID: 30586
		[Token(Token = "0x400777A")]
		private const string SPAWNGRIDITEMANIM_NAME = "VFX_UI002";

		// Token: 0x0400777B RID: 30587
		[Token(Token = "0x400777B")]
		[FieldOffset(Offset = "0x104")]
		private float m_SpawnGridItemPlayTime;

		// Token: 0x0400777C RID: 30588
		[Token(Token = "0x400777C")]
		[FieldOffset(Offset = "0x108")]
		private CSGetMonopolyConfigRes m_Config;

		// Token: 0x0400777D RID: 30589
		[Token(Token = "0x400777D")]
		[FieldOffset(Offset = "0x110")]
		private CSPlayerMonopolyInfo m_GameInfo;

		// Token: 0x0400777E RID: 30590
		[Token(Token = "0x400777E")]
		[FieldOffset(Offset = "0x118")]
		private MonopolySettingDesc m_GameSettingDesc;

		// Token: 0x0400777F RID: 30591
		[Token(Token = "0x400777F")]
		[FieldOffset(Offset = "0x120")]
		private bool m_IsShowingProcess;

		// Token: 0x04007780 RID: 30592
		[Token(Token = "0x4007780")]
		[FieldOffset(Offset = "0x124")]
		private int m_CurrentTriggerEventInx;

		// Token: 0x04007781 RID: 30593
		[Token(Token = "0x4007781")]
		[FieldOffset(Offset = "0x128")]
		private EActivity.State m_ActivityState;

		// Token: 0x04007782 RID: 30594
		[Token(Token = "0x4007782")]
		[FieldOffset(Offset = "0x130")]
		protected UIPopupGlassBG m_Glass;

		// Token: 0x04007783 RID: 30595
		[Token(Token = "0x4007783")]
		[FieldOffset(Offset = "0x138")]
		public UIGlassBGController GlassCtrl;

		// Token: 0x04007784 RID: 30596
		[Token(Token = "0x4007784")]
		[FieldOffset(Offset = "0x140")]
		private bool m_HasInitGlass;

		// Token: 0x04007785 RID: 30597
		[Token(Token = "0x4007785")]
		[FieldOffset(Offset = "0x141")]
		private bool m_HasCheckRuleGuide;

		// Token: 0x04007786 RID: 30598
		[Token(Token = "0x4007786")]
		[FieldOffset(Offset = "0x142")]
		private bool m_HasCheckRollGuide;

		// Token: 0x04007787 RID: 30599
		[Token(Token = "0x4007787")]
		private const string DICEGAMEGUIDE_RULE = "DICEGAMEGUIDE_RULE";

		// Token: 0x04007788 RID: 30600
		[Token(Token = "0x4007788")]
		private const string DICEGAMEGUIDE_ROLLDICE = "DICEGAMEGUIDE_ROLLDICE";

		// Token: 0x04007789 RID: 30601
		[Token(Token = "0x4007789")]
		private const string PHASE_DIALOG = "PHASE_DIALOG";

		// Token: 0x0400778A RID: 30602
		[Token(Token = "0x400778A")]
		[FieldOffset(Offset = "0x143")]
		private bool m_HasClickRule;

		// Token: 0x0400778B RID: 30603
		[Token(Token = "0x400778B")]
		private const string CHECK_RULE_STR = "CHECK_RULE_STR";

		// Token: 0x0400778C RID: 30604
		[Token(Token = "0x400778C")]
		private const float ShowPerCharDura = 0.05f;

		// Token: 0x0400778D RID: 30605
		[Token(Token = "0x400778D")]
		[FieldOffset(Offset = "0x148")]
		private IEnumerator m_TypeCor;

		// Token: 0x0400778E RID: 30606
		[Token(Token = "0x400778E")]
		private const string BUFF_SHOW_ANIMNAME = "UIDiceBuff01";

		// Token: 0x0400778F RID: 30607
		[Token(Token = "0x400778F")]
		private const string BUFF_HIDE_ANIMNAME = "UIDiceBuff02";

		// Token: 0x04007790 RID: 30608
		[Token(Token = "0x4007790")]
		[FieldOffset(Offset = "0x150")]
		private uint m_RuleGuideDelayCallID;

		// Token: 0x04007791 RID: 30609
		[Token(Token = "0x4007791")]
		[FieldOffset(Offset = "0x154")]
		private uint m_RollGuideDelayCallID;

		// Token: 0x04007792 RID: 30610
		[Token(Token = "0x4007792")]
		[FieldOffset(Offset = "0x158")]
		private string m_DialogStr;

		// Token: 0x04007793 RID: 30611
		[Token(Token = "0x4007793")]
		[FieldOffset(Offset = "0x160")]
		private bool m_IsFirstClick;

		// Token: 0x04007794 RID: 30612
		[Token(Token = "0x4007794")]
		[FieldOffset(Offset = "0x164")]
		private int m_CacheDiceCnt;

		// Token: 0x04007795 RID: 30613
		[Token(Token = "0x4007795")]
		[FieldOffset(Offset = "0x168")]
		private int m_CacheTokenCnt;

		// Token: 0x04007796 RID: 30614
		[Token(Token = "0x4007796")]
		[FieldOffset(Offset = "0x16C")]
		private EGotItemAnimType m_GotItemAnimType;

		// Token: 0x04007797 RID: 30615
		[Token(Token = "0x4007797")]
		[FieldOffset(Offset = "0x170")]
		private int m_DeltaDice;

		// Token: 0x04007798 RID: 30616
		[Token(Token = "0x4007798")]
		[FieldOffset(Offset = "0x174")]
		private int m_DeltaToken;

		// Token: 0x04007799 RID: 30617
		[Token(Token = "0x4007799")]
		[FieldOffset(Offset = "0x178")]
		private uint m_GoThroughtStartPointDelayCallID;

		// Token: 0x0400779A RID: 30618
		[Token(Token = "0x400779A")]
		[FieldOffset(Offset = "0x17C")]
		private uint m_MoveEndDelayCallID;

		// Token: 0x0400779B RID: 30619
		[Token(Token = "0x400779B")]
		[FieldOffset(Offset = "0x180")]
		private bool m_IsHookByPopWnd;

		// Token: 0x0400779C RID: 30620
		[Token(Token = "0x400779C")]
		[FieldOffset(Offset = "0x181")]
		private bool m_CacheIsFillBoardByConfig;

		// Token: 0x0400779D RID: 30621
		[Token(Token = "0x400779D")]
		[FieldOffset(Offset = "0x184")]
		private uint m_CachePlayerInx;

		// Token: 0x0400779E RID: 30622
		[Token(Token = "0x400779E")]
		[FieldOffset(Offset = "0x188")]
		private bool m_HasShowStartAnim;

		// Token: 0x0400779F RID: 30623
		[Token(Token = "0x400779F")]
		[FieldOffset(Offset = "0x189")]
		private bool hasShowZeroBuffTime;

		// Token: 0x040077A0 RID: 30624
		[Token(Token = "0x40077A0")]
		[FieldOffset(Offset = "0x18A")]
		private bool isBuffViewHide;

		// Token: 0x040077A1 RID: 30625
		[Token(Token = "0x40077A1")]
		[FieldOffset(Offset = "0x18B")]
		private bool m_IsFirstClickRollMask;

		// Token: 0x040077A2 RID: 30626
		[Token(Token = "0x40077A2")]
		[FieldOffset(Offset = "0x18C")]
		private uint m_RollDiceDelayCallID;

		// Token: 0x040077A3 RID: 30627
		[Token(Token = "0x40077A3")]
		[FieldOffset(Offset = "0x190")]
		private bool m_IsPlayingRollDiceEnd;

		// Token: 0x040077A4 RID: 30628
		[Token(Token = "0x40077A4")]
		[FieldOffset(Offset = "0x194")]
		private uint m_CacheActivityId;

		// Token: 0x02001399 RID: 5017
		[Token(Token = "0x2001399")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB8A0", Offset = "0x10EB8A0")]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x06005129 RID: 20777 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005129")]
			[Address(RVA = "0x21FC4A0", Offset = "0x21FC4A0", VA = "0x7BBC9FC4A0")]
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x0600512A RID: 20778 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600512A")]
			[Address(RVA = "0x220340C", Offset = "0x220340C", VA = "0x7BBCA0340C")]
			internal void <InitGuide>b__2()
			{
			}

			// Token: 0x040077A5 RID: 30629
			[Token(Token = "0x40077A5")]
			[FieldOffset(Offset = "0x10")]
			public Action action;

			// Token: 0x040077A6 RID: 30630
			[Token(Token = "0x40077A6")]
			[FieldOffset(Offset = "0x18")]
			public UIDiceGameMainController <>4__this;
		}

		// Token: 0x0200139A RID: 5018
		[Token(Token = "0x200139A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB8B0", Offset = "0x10EB8B0")]
		private sealed class <CoTypeDialog>d__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600512B RID: 20779 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600512B")]
			[Address(RVA = "0x21FC9DC", Offset = "0x21FC9DC", VA = "0x7BBC9FC9DC")]
			[DebuggerHidden]
			public <CoTypeDialog>d__46(int <>1__state)
			{
			}

			// Token: 0x0600512C RID: 20780 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600512C")]
			[Address(RVA = "0x22034B0", Offset = "0x22034B0", VA = "0x7BBCA034B0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600512D RID: 20781 RVA: 0x00018888 File Offset: 0x00016A88
			[Token(Token = "0x600512D")]
			[Address(RVA = "0x22034B4", Offset = "0x22034B4", VA = "0x7BBCA034B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000869 RID: 2153
			// (get) Token: 0x0600512E RID: 20782 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000869")]
			private object Current
			{
				[Token(Token = "0x600512E")]
				[Address(RVA = "0x22036CC", Offset = "0x22036CC", VA = "0x7BBCA036CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600512F RID: 20783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600512F")]
			[Address(RVA = "0x22036D4", Offset = "0x22036D4", VA = "0x7BBCA036D4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700086A RID: 2154
			// (get) Token: 0x06005130 RID: 20784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700086A")]
			private object Current
			{
				[Token(Token = "0x6005130")]
				[Address(RVA = "0x220373C", Offset = "0x220373C", VA = "0x7BBCA0373C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040077A7 RID: 30631
			[Token(Token = "0x40077A7")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040077A8 RID: 30632
			[Token(Token = "0x40077A8")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040077A9 RID: 30633
			[Token(Token = "0x40077A9")]
			[FieldOffset(Offset = "0x20")]
			public UILabel label;

			// Token: 0x040077AA RID: 30634
			[Token(Token = "0x40077AA")]
			[FieldOffset(Offset = "0x28")]
			public string str;

			// Token: 0x040077AB RID: 30635
			[Token(Token = "0x40077AB")]
			[FieldOffset(Offset = "0x30")]
			public UIDiceGameMainController <>4__this;

			// Token: 0x040077AC RID: 30636
			[Token(Token = "0x40077AC")]
			[FieldOffset(Offset = "0x38")]
			private char[] <>7__wrap1;

			// Token: 0x040077AD RID: 30637
			[Token(Token = "0x40077AD")]
			[FieldOffset(Offset = "0x40")]
			private int <>7__wrap2;
		}

		// Token: 0x0200139B RID: 5019
		[Token(Token = "0x200139B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB8C0", Offset = "0x10EB8C0")]
		private sealed class <>c__DisplayClass95_0
		{
			// Token: 0x06005131 RID: 20785 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005131")]
			[Address(RVA = "0x2201C18", Offset = "0x2201C18", VA = "0x7BBCA01C18")]
			public <>c__DisplayClass95_0()
			{
			}

			// Token: 0x06005132 RID: 20786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005132")]
			[Address(RVA = "0x2203458", Offset = "0x2203458", VA = "0x7BBCA03458")]
			internal void <_DelayCall>b__0()
			{
			}

			// Token: 0x040077AE RID: 30638
			[Token(Token = "0x40077AE")]
			[FieldOffset(Offset = "0x10")]
			public UIDiceGameMainController <>4__this;

			// Token: 0x040077AF RID: 30639
			[Token(Token = "0x40077AF")]
			[FieldOffset(Offset = "0x18")]
			public Action action;
		}

		// Token: 0x0200139C RID: 5020
		[Token(Token = "0x200139C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB8D0", Offset = "0x10EB8D0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005134 RID: 20788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005134")]
			[Address(RVA = "0x22033F8", Offset = "0x22033F8", VA = "0x7BBCA033F8")]
			public <>c()
			{
			}

			// Token: 0x06005135 RID: 20789 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005135")]
			[Address(RVA = "0x2203400", Offset = "0x2203400", VA = "0x7BBCA03400")]
			internal CommonRewardItemInfo <ShowRwd>b__96_0(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x040077B0 RID: 30640
			[Token(Token = "0x40077B0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIDiceGameMainController.<>c <>9;

			// Token: 0x040077B1 RID: 30641
			[Token(Token = "0x40077B1")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__96_0;
		}
	}
}
