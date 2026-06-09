using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020014F1 RID: 5361
	[Token(Token = "0x20014F1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDCFC", Offset = "0x10EDCFC")]
	public class UIEPDailyTaskController : UIBaseController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06005BC4 RID: 23492 RVA: 0x0001AC70 File Offset: 0x00018E70
		[Token(Token = "0x6005BC4")]
		[Address(RVA = "0x220E8D0", Offset = "0x220E8D0", VA = "0x7BBCA0E8D0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005BC5 RID: 23493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC5")]
		[Address(RVA = "0x220E920", Offset = "0x220E920", VA = "0x7BBCA0E920", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005BC6 RID: 23494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC6")]
		[Address(RVA = "0x220EF04", Offset = "0x220EF04", VA = "0x7BBCA0EF04")]
		public void OnDailySignBtn()
		{
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC7")]
		[Address(RVA = "0x220EFA4", Offset = "0x220EFA4", VA = "0x7BBCA0EFA4", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC8")]
		[Address(RVA = "0x220F18C", Offset = "0x220F18C", VA = "0x7BBCA0F18C")]
		private void OnEpDataReady(params object[] data)
		{
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC9")]
		[Address(RVA = "0x220FE8C", Offset = "0x220FE8C", VA = "0x7BBCA0FE8C")]
		private void OnEpDailyRewardClaim(params object[] data)
		{
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCA")]
		[Address(RVA = "0x220FEB0", Offset = "0x220FEB0", VA = "0x7BBCA0FEB0")]
		private void OnEpDailyRewardStateUpdate(params object[] data)
		{
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCB")]
		[Address(RVA = "0x221010C", Offset = "0x221010C", VA = "0x7BBCA1010C")]
		private void OnUpgradeEPBtn()
		{
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCC")]
		[Address(RVA = "0x220EE80", Offset = "0x220EE80", VA = "0x7BBCA0EE80")]
		private void InitData()
		{
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCD")]
		[Address(RVA = "0x2210634", Offset = "0x2210634", VA = "0x7BBCA10634")]
		private void Update()
		{
		}

		// Token: 0x06005BCE RID: 23502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCE")]
		[Address(RVA = "0x22106AC", Offset = "0x22106AC", VA = "0x7BBCA106AC")]
		private void _OnAnimPlayDone()
		{
		}

		// Token: 0x06005BCF RID: 23503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCF")]
		[Address(RVA = "0x220FF6C", Offset = "0x220FF6C", VA = "0x7BBCA0FF6C")]
		private void SetPlayAnim(uint process, uint lastProcess)
		{
		}

		// Token: 0x06005BD0 RID: 23504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD0")]
		[Address(RVA = "0x2210A90", Offset = "0x2210A90", VA = "0x7BBCA10A90")]
		private void InitAnim(uint doneCnt, bool forceToEnd = false)
		{
		}

		// Token: 0x06005BD1 RID: 23505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD1")]
		[Address(RVA = "0x220FD14", Offset = "0x220FD14", VA = "0x7BBCA0FD14")]
		private void RefreshTaskList()
		{
		}

		// Token: 0x06005BD2 RID: 23506 RVA: 0x0001AC88 File Offset: 0x00018E88
		[Token(Token = "0x6005BD2")]
		[Address(RVA = "0x2210CF8", Offset = "0x2210CF8", VA = "0x7BBCA10CF8")]
		private int SortTaskList(EPDailyQuestInfo q1, EPDailyQuestInfo q2)
		{
			return 0;
		}

		// Token: 0x06005BD3 RID: 23507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD3")]
		[Address(RVA = "0x220F1C0", Offset = "0x220F1C0", VA = "0x7BBCA0F1C0")]
		private void RefreshRewardList()
		{
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD4")]
		[Address(RVA = "0x2210188", Offset = "0x2210188", VA = "0x7BBCA10188")]
		private void RefreshSignBtn()
		{
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD5")]
		[Address(RVA = "0x220FC18", Offset = "0x220FC18", VA = "0x7BBCA0FC18")]
		private void RefreshDesc()
		{
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD6")]
		[Address(RVA = "0x220F78C", Offset = "0x220F78C", VA = "0x7BBCA0F78C")]
		private void RefreshTaskProcess()
		{
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD7")]
		[Address(RVA = "0x2210558", Offset = "0x2210558", VA = "0x7BBCA10558")]
		private void RefreshDebrisInfo()
		{
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD8")]
		[Address(RVA = "0x2210F44", Offset = "0x2210F44", VA = "0x7BBCA10F44", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x0001ACA0 File Offset: 0x00018EA0
		[Token(Token = "0x6005BD9")]
		[Address(RVA = "0x2211008", Offset = "0x2211008", VA = "0x7BBCA11008", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BDA")]
		[Address(RVA = "0x221035C", Offset = "0x221035C", VA = "0x7BBCA1035C")]
		private void SetCDN(params object[] data)
		{
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BDB")]
		[Address(RVA = "0x221104C", Offset = "0x221104C", VA = "0x7BBCA1104C", Slot = "30")]
		private UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BDC")]
		[Address(RVA = "0x2211108", Offset = "0x2211108", VA = "0x7BBCA11108", Slot = "31")]
		private void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BDD")]
		[Address(RVA = "0x2211138", Offset = "0x2211138", VA = "0x7BBCA11138")]
		public UIEPDailyTaskController()
		{
		}

		// Token: 0x04007E31 RID: 32305
		[Token(Token = "0x4007E31")]
		[FieldOffset(Offset = "0x58")]
		private UIEPDailyTaskView m_View;

		// Token: 0x04007E32 RID: 32306
		[Token(Token = "0x4007E32")]
		[FieldOffset(Offset = "0x60")]
		private UIEPDebrisProcessController m_EpDebrisCtrl;

		// Token: 0x04007E33 RID: 32307
		[Token(Token = "0x4007E33")]
		[FieldOffset(Offset = "0x68")]
		private List<UIEPDailyTaskRewardItemController> m_RewardList;

		// Token: 0x04007E34 RID: 32308
		[Token(Token = "0x4007E34")]
		private const string EPDAILYTASKFIRSTTIP = "EPDAILYTASKFIRSTTIP";

		// Token: 0x04007E35 RID: 32309
		[Token(Token = "0x4007E35")]
		private const string ANIMPREFIX = "VFX_UITaskReward_Path_";

		// Token: 0x04007E36 RID: 32310
		[Token(Token = "0x4007E36")]
		[FieldOffset(Offset = "0x70")]
		private UIModelElitePass m_ModelEP;

		// Token: 0x04007E37 RID: 32311
		[Token(Token = "0x4007E37")]
		[FieldOffset(Offset = "0x78")]
		private List<string> NeedPlayAnimClipLst;

		// Token: 0x04007E38 RID: 32312
		[Token(Token = "0x4007E38")]
		[FieldOffset(Offset = "0x80")]
		private List<Transform> m_RewardsPosLst;

		// Token: 0x04007E39 RID: 32313
		[Token(Token = "0x4007E39")]
		[FieldOffset(Offset = "0x88")]
		private bool needPlayAnim;

		// Token: 0x04007E3A RID: 32314
		[Token(Token = "0x4007E3A")]
		[FieldOffset(Offset = "0x90")]
		private string curPlayClipName;

		// Token: 0x04007E3B RID: 32315
		[Token(Token = "0x4007E3B")]
		[FieldOffset(Offset = "0x98")]
		private uint curProcessID;

		// Token: 0x04007E3C RID: 32316
		[Token(Token = "0x4007E3C")]
		[FieldOffset(Offset = "0x9C")]
		private int hadPlayCnt;

		// Token: 0x020014F2 RID: 5362
		[Token(Token = "0x20014F2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EDD34", Offset = "0x10EDD34")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005BDF RID: 23519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BDF")]
			[Address(RVA = "0x2211244", Offset = "0x2211244", VA = "0x7BBCA11244")]
			public <>c()
			{
			}

			// Token: 0x06005BE0 RID: 23520 RVA: 0x0001ACB8 File Offset: 0x00018EB8
			[Token(Token = "0x6005BE0")]
			[Address(RVA = "0x221124C", Offset = "0x221124C", VA = "0x7BBCA1124C")]
			internal int <RefreshRewardList>b__27_0(EPDailyRewardInfo a, EPDailyRewardInfo b)
			{
				return 0;
			}

			// Token: 0x06005BE1 RID: 23521 RVA: 0x0001ACD0 File Offset: 0x00018ED0
			[Token(Token = "0x6005BE1")]
			[Address(RVA = "0x22112B4", Offset = "0x22112B4", VA = "0x7BBCA112B4")]
			internal bool <RefreshTaskProcess>b__30_0(EPDailyRewardInfo e)
			{
				return default(bool);
			}

			// Token: 0x06005BE2 RID: 23522 RVA: 0x0001ACE8 File Offset: 0x00018EE8
			[Token(Token = "0x6005BE2")]
			[Address(RVA = "0x22112E8", Offset = "0x22112E8", VA = "0x7BBCA112E8")]
			internal bool <SetCDN>b__34_0(AdvertDesc x)
			{
				return default(bool);
			}

			// Token: 0x04007E3D RID: 32317
			[Token(Token = "0x4007E3D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIEPDailyTaskController.<>c <>9;

			// Token: 0x04007E3E RID: 32318
			[Token(Token = "0x4007E3E")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<EPDailyRewardInfo> <>9__27_0;

			// Token: 0x04007E3F RID: 32319
			[Token(Token = "0x4007E3F")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<EPDailyRewardInfo> <>9__30_0;

			// Token: 0x04007E40 RID: 32320
			[Token(Token = "0x4007E40")]
			[FieldOffset(Offset = "0x18")]
			public static Predicate<AdvertDesc> <>9__34_0;
		}
	}
}
