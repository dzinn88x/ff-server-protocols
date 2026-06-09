using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E52 RID: 7762
	[Token(Token = "0x2001E52")]
	public class UIModelFFWS : UIBaseModel, IBigEventModel
	{
		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x0600AA35 RID: 43573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B42")]
		public CSFFWSBoxSignInRes BoxSignInRes
		{
			[Token(Token = "0x600AA35")]
			[Address(RVA = "0x23A5B38", Offset = "0x23A5B38", VA = "0x7BBCBA5B38")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AA36 RID: 43574 RVA: 0x0002E638 File Offset: 0x0002C838
		[Token(Token = "0x600AA36")]
		[Address(RVA = "0x23A5B40", Offset = "0x23A5B40", VA = "0x7BBCBA5B40", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600AA37 RID: 43575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA37")]
		[Address(RVA = "0x23A5B48", Offset = "0x23A5B48", VA = "0x7BBCBA5B48", Slot = "14")]
		public void OnProcessEventOpenInfo()
		{
		}

		// Token: 0x0600AA38 RID: 43576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA38")]
		[Address(RVA = "0x23A5B4C", Offset = "0x23A5B4C", VA = "0x7BBCBA5B4C", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600AA39 RID: 43577 RVA: 0x0002E650 File Offset: 0x0002C850
		[Token(Token = "0x600AA39")]
		[Address(RVA = "0x23A5C04", Offset = "0x23A5C04", VA = "0x7BBCBA5C04")]
		public bool HaveSetting()
		{
			return default(bool);
		}

		// Token: 0x0600AA3A RID: 43578 RVA: 0x0002E668 File Offset: 0x0002C868
		[Token(Token = "0x600AA3A")]
		[Address(RVA = "0x23A5C14", Offset = "0x23A5C14", VA = "0x7BBCBA5C14")]
		public uint GetCurrentSpTaskIndex(out uint id)
		{
			return 0U;
		}

		// Token: 0x0600AA3B RID: 43579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA3B")]
		[Address(RVA = "0x23A5E04", Offset = "0x23A5E04", VA = "0x7BBCBA5E04")]
		public FFWSSpecialTaskTextDesc GetCurrentSpTask()
		{
			return null;
		}

		// Token: 0x0600AA3C RID: 43580 RVA: 0x0002E680 File Offset: 0x0002C880
		[Token(Token = "0x600AA3C")]
		[Address(RVA = "0x23A5FC4", Offset = "0x23A5FC4", VA = "0x7BBCBA5FC4")]
		public uint GetSpTaskIndex()
		{
			return 0U;
		}

		// Token: 0x0600AA3D RID: 43581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA3D")]
		[Address(RVA = "0x23A61D0", Offset = "0x23A61D0", VA = "0x7BBCBA61D0")]
		public void CheckProgressAndRequestReceiveSPTask()
		{
		}

		// Token: 0x0600AA3E RID: 43582 RVA: 0x0002E698 File Offset: 0x0002C898
		[Token(Token = "0x600AA3E")]
		[Address(RVA = "0x23A646C", Offset = "0x23A646C", VA = "0x7BBCBA646C")]
		public int GetActivityTime()
		{
			return 0;
		}

		// Token: 0x0600AA3F RID: 43583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA3F")]
		[Address(RVA = "0x23A66C0", Offset = "0x23A66C0", VA = "0x7BBCBA66C0")]
		public string GetDailyTaskText()
		{
			return null;
		}

		// Token: 0x0600AA40 RID: 43584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA40")]
		[Address(RVA = "0x23A68A8", Offset = "0x23A68A8", VA = "0x7BBCBA68A8")]
		public void GetTaskActivityListDesc(out List<ClientActivityDesc> activityDescList, out bool is_Expired)
		{
		}

		// Token: 0x0600AA41 RID: 43585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA41")]
		[Address(RVA = "0x23A696C", Offset = "0x23A696C", VA = "0x7BBCBA696C")]
		public void GetSpTaskActivityListDesc(out ClientActivityDesc activityDesc, uint id)
		{
		}

		// Token: 0x0600AA42 RID: 43586 RVA: 0x0002E6B0 File Offset: 0x0002C8B0
		[Token(Token = "0x600AA42")]
		[Address(RVA = "0x23A6A28", Offset = "0x23A6A28", VA = "0x7BBCBA6A28")]
		public bool CheckTaskTip()
		{
			return default(bool);
		}

		// Token: 0x0600AA43 RID: 43587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA43")]
		[Address(RVA = "0x23A6CA8", Offset = "0x23A6CA8", VA = "0x7BBCBA6CA8")]
		public void GetStoreRes(uint option = 0U)
		{
		}

		// Token: 0x0600AA44 RID: 43588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA44")]
		[Address(RVA = "0x23A6EB4", Offset = "0x23A6EB4", VA = "0x7BBCBA6EB4")]
		public List<LimitedEventStore> GetStoreList()
		{
			return null;
		}

		// Token: 0x0600AA45 RID: 43589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA45")]
		[Address(RVA = "0x23A6EBC", Offset = "0x23A6EBC", VA = "0x7BBCBA6EBC")]
		public List<BigEventStoreCommodityDesc> GetStoreItemsList(uint id)
		{
			return null;
		}

		// Token: 0x0600AA46 RID: 43590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA46")]
		[Address(RVA = "0x23A7028", Offset = "0x23A7028", VA = "0x7BBCBA7028")]
		public void RequesePurchase(BigEventStoreCommodityDesc desc, uint cnt = 1U)
		{
		}

		// Token: 0x0600AA47 RID: 43591 RVA: 0x0002E6C8 File Offset: 0x0002C8C8
		[Token(Token = "0x600AA47")]
		[Address(RVA = "0x23A7544", Offset = "0x23A7544", VA = "0x7BBCBA7544")]
		public int SortStoreItem(BigEventStoreCommodityDesc a, BigEventStoreCommodityDesc b)
		{
			return 0;
		}

		// Token: 0x0600AA48 RID: 43592 RVA: 0x0002E6E0 File Offset: 0x0002C8E0
		[Token(Token = "0x600AA48")]
		[Address(RVA = "0x23A77E8", Offset = "0x23A77E8", VA = "0x7BBCBA77E8")]
		public bool HavePlayEnterAnim()
		{
			return default(bool);
		}

		// Token: 0x0600AA49 RID: 43593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA49")]
		[Address(RVA = "0x23A7868", Offset = "0x23A7868", VA = "0x7BBCBA7868")]
		public void SetPlayedEnterAnim()
		{
		}

		// Token: 0x0600AA4A RID: 43594 RVA: 0x0002E6F8 File Offset: 0x0002C8F8
		[Token(Token = "0x600AA4A")]
		[Address(RVA = "0x23A78DC", Offset = "0x23A78DC", VA = "0x7BBCBA78DC")]
		public bool HaveShownTutorialMainPageMissionBtn()
		{
			return default(bool);
		}

		// Token: 0x0600AA4B RID: 43595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA4B")]
		[Address(RVA = "0x23A795C", Offset = "0x23A795C", VA = "0x7BBCBA795C")]
		public void SetShownTutorialMainPageMissionBtn()
		{
		}

		// Token: 0x0600AA4C RID: 43596 RVA: 0x0002E710 File Offset: 0x0002C910
		[Token(Token = "0x600AA4C")]
		[Address(RVA = "0x23A79D0", Offset = "0x23A79D0", VA = "0x7BBCBA79D0")]
		public bool HaveShownTutorialMainPageGuessBtn()
		{
			return default(bool);
		}

		// Token: 0x0600AA4D RID: 43597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA4D")]
		[Address(RVA = "0x23A7A50", Offset = "0x23A7A50", VA = "0x7BBCBA7A50")]
		public void SetShownTutorialMainPageGuessBtn()
		{
		}

		// Token: 0x0600AA4E RID: 43598 RVA: 0x0002E728 File Offset: 0x0002C928
		[Token(Token = "0x600AA4E")]
		[Address(RVA = "0x23A7AC4", Offset = "0x23A7AC4", VA = "0x7BBCBA7AC4")]
		public bool HaveShownTutorialMainPageAwaken()
		{
			return default(bool);
		}

		// Token: 0x0600AA4F RID: 43599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA4F")]
		[Address(RVA = "0x23A7B44", Offset = "0x23A7B44", VA = "0x7BBCBA7B44")]
		public void SetShownTutorialMainPageAwaken()
		{
		}

		// Token: 0x0600AA50 RID: 43600 RVA: 0x0002E740 File Offset: 0x0002C940
		[Token(Token = "0x600AA50")]
		[Address(RVA = "0x23A7BB8", Offset = "0x23A7BB8", VA = "0x7BBCBA7BB8")]
		public bool HaveShownTutorialGuessFirstEntering()
		{
			return default(bool);
		}

		// Token: 0x0600AA51 RID: 43601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA51")]
		[Address(RVA = "0x23A7C38", Offset = "0x23A7C38", VA = "0x7BBCBA7C38")]
		public void SetShownTutorialGuessFirstEntering()
		{
		}

		// Token: 0x0600AA52 RID: 43602 RVA: 0x0002E758 File Offset: 0x0002C958
		[Token(Token = "0x600AA52")]
		[Address(RVA = "0x23A7CAC", Offset = "0x23A7CAC", VA = "0x7BBCBA7CAC")]
		public bool HaveShownTutorialGuessNextRound()
		{
			return default(bool);
		}

		// Token: 0x0600AA53 RID: 43603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA53")]
		[Address(RVA = "0x23A7D2C", Offset = "0x23A7D2C", VA = "0x7BBCBA7D2C")]
		public void SetShownTutorialGuessNextRound()
		{
		}

		// Token: 0x0600AA54 RID: 43604 RVA: 0x0002E770 File Offset: 0x0002C970
		[Token(Token = "0x600AA54")]
		[Address(RVA = "0x23A7DA0", Offset = "0x23A7DA0", VA = "0x7BBCBA7DA0")]
		public bool HavePlayedAvatarAwakenAnim()
		{
			return default(bool);
		}

		// Token: 0x0600AA55 RID: 43605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA55")]
		[Address(RVA = "0x23A7E20", Offset = "0x23A7E20", VA = "0x7BBCBA7E20")]
		public void SetPlayedAvatarAwakenAnim()
		{
		}

		// Token: 0x0600AA56 RID: 43606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA56")]
		[Address(RVA = "0x23A7E94", Offset = "0x23A7E94", VA = "0x7BBCBA7E94")]
		public string GetCDNMainPageTitle()
		{
			return null;
		}

		// Token: 0x0600AA57 RID: 43607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA57")]
		[Address(RVA = "0x23A7F3C", Offset = "0x23A7F3C", VA = "0x7BBCBA7F3C")]
		public string GetCDNWarmUpTitle()
		{
			return null;
		}

		// Token: 0x0600AA58 RID: 43608 RVA: 0x0002E788 File Offset: 0x0002C988
		[Token(Token = "0x600AA58")]
		[Address(RVA = "0x23A7FE4", Offset = "0x23A7FE4", VA = "0x7BBCBA7FE4")]
		public uint GetTokenID()
		{
			return 0U;
		}

		// Token: 0x0600AA59 RID: 43609 RVA: 0x0002E7A0 File Offset: 0x0002C9A0
		[Token(Token = "0x600AA59")]
		[Address(RVA = "0x23A7FFC", Offset = "0x23A7FFC", VA = "0x7BBCBA7FFC")]
		public ResourceID GetTokenIconRes()
		{
			return default(ResourceID);
		}

		// Token: 0x0600AA5A RID: 43610 RVA: 0x0002E7B8 File Offset: 0x0002C9B8
		[Token(Token = "0x600AA5A")]
		[Address(RVA = "0x23A80E0", Offset = "0x23A80E0", VA = "0x7BBCBA80E0")]
		public uint GetTokenCount()
		{
			return 0U;
		}

		// Token: 0x0600AA5B RID: 43611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA5B")]
		[Address(RVA = "0x23A81BC", Offset = "0x23A81BC", VA = "0x7BBCBA81BC")]
		public string GetWebUrl()
		{
			return null;
		}

		// Token: 0x0600AA5C RID: 43612 RVA: 0x0002E7D0 File Offset: 0x0002C9D0
		[Token(Token = "0x600AA5C")]
		[Address(RVA = "0x23A8220", Offset = "0x23A8220", VA = "0x7BBCBA8220")]
		public bool CupIsDuringShowTeamsTime()
		{
			return default(bool);
		}

		// Token: 0x0600AA5D RID: 43613 RVA: 0x0002E7E8 File Offset: 0x0002C9E8
		[Token(Token = "0x600AA5D")]
		[Address(RVA = "0x23A82A8", Offset = "0x23A82A8", VA = "0x7BBCBA82A8")]
		public bool CupIsDuringShowChampionTime()
		{
			return default(bool);
		}

		// Token: 0x0600AA5E RID: 43614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA5E")]
		[Address(RVA = "0x23A8340", Offset = "0x23A8340", VA = "0x7BBCBA8340")]
		public string GetCupWebUrlTeams()
		{
			return null;
		}

		// Token: 0x0600AA5F RID: 43615 RVA: 0x0002E800 File Offset: 0x0002CA00
		[Token(Token = "0x600AA5F")]
		[Address(RVA = "0x23A8358", Offset = "0x23A8358", VA = "0x7BBCBA8358")]
		public bool NeedShowCupRedPointTeams()
		{
			return default(bool);
		}

		// Token: 0x0600AA60 RID: 43616 RVA: 0x0002E818 File Offset: 0x0002CA18
		[Token(Token = "0x600AA60")]
		[Address(RVA = "0x23A83F0", Offset = "0x23A83F0", VA = "0x7BBCBA83F0")]
		public bool NeedShowCupRedPointChampion()
		{
			return default(bool);
		}

		// Token: 0x0600AA61 RID: 43617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA61")]
		[Address(RVA = "0x23A8488", Offset = "0x23A8488", VA = "0x7BBCBA8488")]
		public void SetShownCupRedPointTeam()
		{
		}

		// Token: 0x0600AA62 RID: 43618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA62")]
		[Address(RVA = "0x23A84FC", Offset = "0x23A84FC", VA = "0x7BBCBA84FC")]
		public void SetShownCupRedPointChamption()
		{
		}

		// Token: 0x0600AA63 RID: 43619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA63")]
		[Address(RVA = "0x23A8570", Offset = "0x23A8570", VA = "0x7BBCBA8570")]
		public string GetCupWebUrlChampion()
		{
			return null;
		}

		// Token: 0x0600AA64 RID: 43620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA64")]
		[Address(RVA = "0x23A8588", Offset = "0x23A8588", VA = "0x7BBCBA8588")]
		public string GetCDNTaskTitle()
		{
			return null;
		}

		// Token: 0x0600AA65 RID: 43621 RVA: 0x0002E830 File Offset: 0x0002CA30
		[Token(Token = "0x600AA65")]
		[Address(RVA = "0x23A8630", Offset = "0x23A8630", VA = "0x7BBCBA8630")]
		public bool GetAwakenProcess(out uint process)
		{
			return default(bool);
		}

		// Token: 0x0600AA66 RID: 43622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA66")]
		[Address(RVA = "0x23A8718", Offset = "0x23A8718", VA = "0x7BBCBA8718")]
		public string GetCDNGuessTitle()
		{
			return null;
		}

		// Token: 0x0600AA67 RID: 43623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA67")]
		[Address(RVA = "0x23A87C0", Offset = "0x23A87C0", VA = "0x7BBCBA87C0")]
		public string GetCDNGuessWinAwardTitle()
		{
			return null;
		}

		// Token: 0x0600AA68 RID: 43624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA68")]
		[Address(RVA = "0x23A8868", Offset = "0x23A8868", VA = "0x7BBCBA8868")]
		public string GetCDNGuessLoseAwardTitle()
		{
			return null;
		}

		// Token: 0x0600AA69 RID: 43625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA69")]
		[Address(RVA = "0x23A8910", Offset = "0x23A8910", VA = "0x7BBCBA8910")]
		public string GetTeamIconCdnUrl(FFWSTeamInfoDesc teamInfo)
		{
			return null;
		}

		// Token: 0x0600AA6A RID: 43626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA6A")]
		[Address(RVA = "0x23A8924", Offset = "0x23A8924", VA = "0x7BBCBA8924")]
		public FFWSTeamInfoDesc GetTeamInfoByTeamId(uint teamId)
		{
			return null;
		}

		// Token: 0x0600AA6B RID: 43627 RVA: 0x0002E848 File Offset: 0x0002CA48
		[Token(Token = "0x600AA6B")]
		[Address(RVA = "0x23A8A00", Offset = "0x23A8A00", VA = "0x7BBCBA8A00")]
		public bool HaveGuessOutcome()
		{
			return default(bool);
		}

		// Token: 0x0600AA6C RID: 43628 RVA: 0x0002E860 File Offset: 0x0002CA60
		[Token(Token = "0x600AA6C")]
		[Address(RVA = "0x23A8A6C", Offset = "0x23A8A6C", VA = "0x7BBCBA8A6C")]
		public uint GetTeamPointAt(uint roundIndex, uint teamId)
		{
			return 0U;
		}

		// Token: 0x0600AA6D RID: 43629 RVA: 0x0002E878 File Offset: 0x0002CA78
		[Token(Token = "0x600AA6D")]
		[Address(RVA = "0x23A8B8C", Offset = "0x23A8B8C", VA = "0x7BBCBA8B8C")]
		public uint GetAIChoiceByRound(uint round)
		{
			return 0U;
		}

		// Token: 0x0600AA6E RID: 43630 RVA: 0x0002E890 File Offset: 0x0002CA90
		[Token(Token = "0x600AA6E")]
		[Address(RVA = "0x23A8BE8", Offset = "0x23A8BE8", VA = "0x7BBCBA8BE8")]
		public uint GetPlayerChoiceByRound(uint round)
		{
			return 0U;
		}

		// Token: 0x0600AA6F RID: 43631 RVA: 0x0002E8A8 File Offset: 0x0002CAA8
		[Token(Token = "0x600AA6F")]
		[Address(RVA = "0x23A8C44", Offset = "0x23A8C44", VA = "0x7BBCBA8C44")]
		public bool IsRoundGuessedByPlayer(uint round)
		{
			return default(bool);
		}

		// Token: 0x0600AA70 RID: 43632 RVA: 0x0002E8C0 File Offset: 0x0002CAC0
		[Token(Token = "0x600AA70")]
		[Address(RVA = "0x23A8C60", Offset = "0x23A8C60", VA = "0x7BBCBA8C60")]
		public UIModelFFWS.GuessAwardStatus GetAwardStatusByRound(uint roundIndex)
		{
			return UIModelFFWS.GuessAwardStatus.CanSee;
		}

		// Token: 0x0600AA71 RID: 43633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA71")]
		[Address(RVA = "0x23A8DB4", Offset = "0x23A8DB4", VA = "0x7BBCBA8DB4")]
		public List<AwardDesc> GetAwardListByRound(uint roundIndex, ELimitedEvent.FFWSGuessingAwardType awardType)
		{
			return null;
		}

		// Token: 0x0600AA72 RID: 43634 RVA: 0x0002E8D8 File Offset: 0x0002CAD8
		[Token(Token = "0x600AA72")]
		[Address(RVA = "0x23A8EB4", Offset = "0x23A8EB4", VA = "0x7BBCBA8EB4")]
		public uint GetTimeStampGuessStart()
		{
			return 0U;
		}

		// Token: 0x0600AA73 RID: 43635 RVA: 0x0002E8F0 File Offset: 0x0002CAF0
		[Token(Token = "0x600AA73")]
		[Address(RVA = "0x23A8ECC", Offset = "0x23A8ECC", VA = "0x7BBCBA8ECC")]
		public uint GetTimeStampGuessEnd()
		{
			return 0U;
		}

		// Token: 0x0600AA74 RID: 43636 RVA: 0x0002E908 File Offset: 0x0002CB08
		[Token(Token = "0x600AA74")]
		[Address(RVA = "0x23A8EE4", Offset = "0x23A8EE4", VA = "0x7BBCBA8EE4")]
		public uint GetTimeStampGuessPageStart()
		{
			return 0U;
		}

		// Token: 0x0600AA75 RID: 43637 RVA: 0x0002E920 File Offset: 0x0002CB20
		[Token(Token = "0x600AA75")]
		[Address(RVA = "0x23A8EFC", Offset = "0x23A8EFC", VA = "0x7BBCBA8EFC")]
		public uint GetTimeStampGuessPageClosed()
		{
			return 0U;
		}

		// Token: 0x0600AA76 RID: 43638 RVA: 0x0002E938 File Offset: 0x0002CB38
		[Token(Token = "0x600AA76")]
		[Address(RVA = "0x23A8F14", Offset = "0x23A8F14", VA = "0x7BBCBA8F14")]
		public bool IsGuessPageAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600AA77 RID: 43639 RVA: 0x0002E950 File Offset: 0x0002CB50
		[Token(Token = "0x600AA77")]
		[Address(RVA = "0x23A8F34", Offset = "0x23A8F34", VA = "0x7BBCBA8F34")]
		public bool IsDuringGuessTime()
		{
			return default(bool);
		}

		// Token: 0x0600AA78 RID: 43640 RVA: 0x0002E968 File Offset: 0x0002CB68
		[Token(Token = "0x600AA78")]
		[Address(RVA = "0x23A8FB8", Offset = "0x23A8FB8", VA = "0x7BBCBA8FB8")]
		public bool IsDuringGuessPageTime()
		{
			return default(bool);
		}

		// Token: 0x0600AA79 RID: 43641 RVA: 0x0002E980 File Offset: 0x0002CB80
		[Token(Token = "0x600AA79")]
		[Address(RVA = "0x23A9040", Offset = "0x23A9040", VA = "0x7BBCBA9040")]
		public bool HavePlayTeamTweenByRound(uint roundIndex)
		{
			return default(bool);
		}

		// Token: 0x0600AA7A RID: 43642 RVA: 0x0002E998 File Offset: 0x0002CB98
		[Token(Token = "0x600AA7A")]
		[Address(RVA = "0x23A9100", Offset = "0x23A9100", VA = "0x7BBCBA9100")]
		public bool HavePlayPointTweenByRound(uint roundIndex)
		{
			return default(bool);
		}

		// Token: 0x0600AA7B RID: 43643 RVA: 0x0002E9B0 File Offset: 0x0002CBB0
		[Token(Token = "0x600AA7B")]
		[Address(RVA = "0x23A91C0", Offset = "0x23A91C0", VA = "0x7BBCBA91C0")]
		public bool HavePlayTeamBreatheTween()
		{
			return default(bool);
		}

		// Token: 0x0600AA7C RID: 43644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA7C")]
		[Address(RVA = "0x23A9240", Offset = "0x23A9240", VA = "0x7BBCBA9240")]
		public string GetCDNStoreTitle()
		{
			return null;
		}

		// Token: 0x0600AA7D RID: 43645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA7D")]
		[Address(RVA = "0x23A92E8", Offset = "0x23A92E8", VA = "0x7BBCBA92E8")]
		public string GetCDNStoreBG()
		{
			return null;
		}

		// Token: 0x0600AA7E RID: 43646 RVA: 0x0002E9C8 File Offset: 0x0002CBC8
		[Token(Token = "0x600AA7E")]
		[Address(RVA = "0x23A9390", Offset = "0x23A9390", VA = "0x7BBCBA9390")]
		public bool IsExchangeAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600AA7F RID: 43647 RVA: 0x0002E9E0 File Offset: 0x0002CBE0
		[Token(Token = "0x600AA7F")]
		[Address(RVA = "0x23A93B0", Offset = "0x23A93B0", VA = "0x7BBCBA93B0")]
		public bool CanExchange()
		{
			return default(bool);
		}

		// Token: 0x0600AA80 RID: 43648 RVA: 0x0002E9F8 File Offset: 0x0002CBF8
		[Token(Token = "0x600AA80")]
		[Address(RVA = "0x23A97A4", Offset = "0x23A97A4", VA = "0x7BBCBA97A4")]
		public bool IsMissionAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600AA81 RID: 43649 RVA: 0x0002EA10 File Offset: 0x0002CC10
		[Token(Token = "0x600AA81")]
		[Address(RVA = "0x23A97C4", Offset = "0x23A97C4", VA = "0x7BBCBA97C4")]
		public bool IsPeakDayAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600AA82 RID: 43650 RVA: 0x0002EA28 File Offset: 0x0002CC28
		[Token(Token = "0x600AA82")]
		[Address(RVA = "0x23A97E4", Offset = "0x23A97E4", VA = "0x7BBCBA97E4")]
		public bool IsLiveAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600AA83 RID: 43651 RVA: 0x0002EA40 File Offset: 0x0002CC40
		[Token(Token = "0x600AA83")]
		[Address(RVA = "0x23A9804", Offset = "0x23A9804", VA = "0x7BBCBA9804")]
		public bool IsLiveNow()
		{
			return default(bool);
		}

		// Token: 0x0600AA84 RID: 43652 RVA: 0x0002EA58 File Offset: 0x0002CC58
		[Token(Token = "0x600AA84")]
		[Address(RVA = "0x23A9894", Offset = "0x23A9894", VA = "0x7BBCBA9894")]
		public bool HavePassedLiveTime()
		{
			return default(bool);
		}

		// Token: 0x0600AA85 RID: 43653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA85")]
		[Address(RVA = "0x23A9924", Offset = "0x23A9924", VA = "0x7BBCBA9924")]
		public string GetLiveWebUrl()
		{
			return null;
		}

		// Token: 0x0600AA86 RID: 43654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA86")]
		[Address(RVA = "0x23A993C", Offset = "0x23A993C", VA = "0x7BBCBA993C")]
		public string GetCDNLiveTitle()
		{
			return null;
		}

		// Token: 0x0600AA87 RID: 43655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA87")]
		[Address(RVA = "0x23A99E4", Offset = "0x23A99E4", VA = "0x7BBCBA99E4")]
		public string GetCDNLiveBg()
		{
			return null;
		}

		// Token: 0x0600AA88 RID: 43656 RVA: 0x0002EA70 File Offset: 0x0002CC70
		[Token(Token = "0x600AA88")]
		[Address(RVA = "0x23A9A8C", Offset = "0x23A9A8C", VA = "0x7BBCBA9A8C")]
		public uint GetTimeStampLiveStart()
		{
			return 0U;
		}

		// Token: 0x0600AA89 RID: 43657 RVA: 0x0002EA88 File Offset: 0x0002CC88
		[Token(Token = "0x600AA89")]
		[Address(RVA = "0x23A9AA4", Offset = "0x23A9AA4", VA = "0x7BBCBA9AA4")]
		public uint GetTimeStampLiveEnd()
		{
			return 0U;
		}

		// Token: 0x0600AA8A RID: 43658 RVA: 0x0002EAA0 File Offset: 0x0002CCA0
		[Token(Token = "0x600AA8A")]
		[Address(RVA = "0x23A9ABC", Offset = "0x23A9ABC", VA = "0x7BBCBA9ABC")]
		public bool IsDuringWebEventTime()
		{
			return default(bool);
		}

		// Token: 0x0600AA8B RID: 43659 RVA: 0x0002EAB8 File Offset: 0x0002CCB8
		[Token(Token = "0x600AA8B")]
		[Address(RVA = "0x23A9B4C", Offset = "0x23A9B4C", VA = "0x7BBCBA9B4C")]
		public bool IsWebEventAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600AA8C RID: 43660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA8C")]
		[Address(RVA = "0x23A9B6C", Offset = "0x23A9B6C", VA = "0x7BBCBA9B6C")]
		public string GetCDNCheckInTitle()
		{
			return null;
		}

		// Token: 0x0600AA8D RID: 43661 RVA: 0x0002EAD0 File Offset: 0x0002CCD0
		[Token(Token = "0x600AA8D")]
		[Address(RVA = "0x23A9C14", Offset = "0x23A9C14", VA = "0x7BBCBA9C14")]
		public bool IsCheckInAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600AA8E RID: 43662 RVA: 0x0002EAE8 File Offset: 0x0002CCE8
		[Token(Token = "0x600AA8E")]
		[Address(RVA = "0x23A9C34", Offset = "0x23A9C34", VA = "0x7BBCBA9C34")]
		public bool CheckIsTurnTable()
		{
			return default(bool);
		}

		// Token: 0x0600AA8F RID: 43663 RVA: 0x0002EB00 File Offset: 0x0002CD00
		[Token(Token = "0x600AA8F")]
		[Address(RVA = "0x23A9D60", Offset = "0x23A9D60", VA = "0x7BBCBA9D60")]
		public bool IsAllSigned()
		{
			return default(bool);
		}

		// Token: 0x0600AA90 RID: 43664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA90")]
		[Address(RVA = "0x23A9D68", Offset = "0x23A9D68", VA = "0x7BBCBA9D68")]
		public void CheckAllSigned()
		{
		}

		// Token: 0x0600AA91 RID: 43665 RVA: 0x0002EB18 File Offset: 0x0002CD18
		[Token(Token = "0x600AA91")]
		[Address(RVA = "0x23A9E18", Offset = "0x23A9E18", VA = "0x7BBCBA9E18")]
		public bool CheckInCanCheckIn()
		{
			return default(bool);
		}

		// Token: 0x0600AA92 RID: 43666 RVA: 0x0002EB30 File Offset: 0x0002CD30
		[Token(Token = "0x600AA92")]
		[Address(RVA = "0x23A9F48", Offset = "0x23A9F48", VA = "0x7BBCBA9F48")]
		public bool CheckInCanClaimAward()
		{
			return default(bool);
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x0600AA93 RID: 43667 RVA: 0x0002EB48 File Offset: 0x0002CD48
		[Token(Token = "0x17000B43")]
		public bool IsCheckIn
		{
			[Token(Token = "0x600AA93")]
			[Address(RVA = "0x23A9F80", Offset = "0x23A9F80", VA = "0x7BBCBA9F80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600AA94 RID: 43668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA94")]
		[Address(RVA = "0x23A9F88", Offset = "0x23A9F88", VA = "0x7BBCBA9F88")]
		public void RequestCheckInStatus(uint option = 0U)
		{
		}

		// Token: 0x0600AA95 RID: 43669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA95")]
		[Address(RVA = "0x23AA148", Offset = "0x23AA148", VA = "0x7BBCBAA148")]
		public void TreasureBoxSignIn(uint option = 0U)
		{
		}

		// Token: 0x0600AA96 RID: 43670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA96")]
		[Address(RVA = "0x23AA2C8", Offset = "0x23AA2C8", VA = "0x7BBCBAA2C8")]
		public void SetTurntableResetTime()
		{
		}

		// Token: 0x0600AA97 RID: 43671 RVA: 0x0002EB60 File Offset: 0x0002CD60
		[Token(Token = "0x600AA97")]
		[Address(RVA = "0x23AA404", Offset = "0x23AA404", VA = "0x7BBCBAA404")]
		public ulong GetTurntableResetTime()
		{
			return 0UL;
		}

		// Token: 0x0600AA98 RID: 43672 RVA: 0x0002EB78 File Offset: 0x0002CD78
		[Token(Token = "0x600AA98")]
		[Address(RVA = "0x23AA40C", Offset = "0x23AA40C", VA = "0x7BBCBAA40C")]
		public bool CheckLastDay(ulong timeStamp)
		{
			return default(bool);
		}

		// Token: 0x0600AA99 RID: 43673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA99")]
		[Address(RVA = "0x23AA588", Offset = "0x23AA588", VA = "0x7BBCBAA588")]
		public void GetFFWSSettingRes(bool forceRequest = false)
		{
		}

		// Token: 0x0600AA9A RID: 43674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA9A")]
		[Address(RVA = "0x23AA818", Offset = "0x23AA818", VA = "0x7BBCBAA818")]
		public void GetFFWSAccountGuessingInfoRes(bool forceRequest = false)
		{
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x0600AA9B RID: 43675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B44")]
		public CSGetFFWSCurProcessRes CurProcessRes
		{
			[Token(Token = "0x600AA9B")]
			[Address(RVA = "0x23AAA10", Offset = "0x23AAA10", VA = "0x7BBCBAAA10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x0600AA9C RID: 43676 RVA: 0x0002EB90 File Offset: 0x0002CD90
		[Token(Token = "0x17000B45")]
		public ulong CurProcessPercentage
		{
			[Token(Token = "0x600AA9C")]
			[Address(RVA = "0x23AAA18", Offset = "0x23AAA18", VA = "0x7BBCBAAA18")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x0600AA9D RID: 43677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA9D")]
		[Address(RVA = "0x23AAA20", Offset = "0x23AAA20", VA = "0x7BBCBAAA20")]
		public void RequestAwakeProgress()
		{
		}

		// Token: 0x0600AA9E RID: 43678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA9E")]
		[Address(RVA = "0x23AAC38", Offset = "0x23AAC38", VA = "0x7BBCBAAC38")]
		public void RefreshAwakePercentage()
		{
		}

		// Token: 0x0600AA9F RID: 43679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA9F")]
		[Address(RVA = "0x23A6254", Offset = "0x23A6254", VA = "0x7BBCBA6254")]
		private void RequestReceiveSpecialTask(uint mSpecialTaskIndex)
		{
		}

		// Token: 0x0600AAA0 RID: 43680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA0")]
		[Address(RVA = "0x23AACA4", Offset = "0x23AACA4", VA = "0x7BBCBAACA4")]
		public void RequestGuess(uint roundIndex, uint teamId)
		{
		}

		// Token: 0x0600AAA1 RID: 43681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA1")]
		[Address(RVA = "0x23AAEE8", Offset = "0x23AAEE8", VA = "0x7BBCBAAEE8")]
		public void RequestClaimGuessAward(uint roundIndex)
		{
		}

		// Token: 0x0600AAA2 RID: 43682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA2")]
		[Address(RVA = "0x23AB0FC", Offset = "0x23AB0FC", VA = "0x7BBCBAB0FC")]
		public void InitTokenTipsDesc()
		{
		}

		// Token: 0x0600AAA3 RID: 43683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AAA3")]
		[Address(RVA = "0x23AB284", Offset = "0x23AB284", VA = "0x7BBCBAB284")]
		public List<BigEventTokenTipsDesc> GetTokenTipsDescList()
		{
			return null;
		}

		// Token: 0x0600AAA4 RID: 43684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA4")]
		[Address(RVA = "0x23AB28C", Offset = "0x23AB28C", VA = "0x7BBCBAB28C")]
		public UIModelFFWS()
		{
		}

		// Token: 0x0600AAA5 RID: 43685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA5")]
		[Address(RVA = "0x23AB394", Offset = "0x23AB394", VA = "0x7BBCBAB394")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11461FC", Offset = "0x11461FC")]
		private void <GetStoreRes>b__56_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AAA6 RID: 43686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA6")]
		[Address(RVA = "0x23AB6C8", Offset = "0x23AB6C8", VA = "0x7BBCBAB6C8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114620C", Offset = "0x114620C")]
		private void <RequestCheckInStatus>b__153_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AAA7 RID: 43687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA7")]
		[Address(RVA = "0x23AB7E0", Offset = "0x23AB7E0", VA = "0x7BBCBAB7E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114621C", Offset = "0x114621C")]
		private void <TreasureBoxSignIn>b__154_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AAA8 RID: 43688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA8")]
		[Address(RVA = "0x23AB910", Offset = "0x23AB910", VA = "0x7BBCBAB910")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114622C", Offset = "0x114622C")]
		private void <GetFFWSAccountGuessingInfoRes>b__160_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AAA9 RID: 43689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAA9")]
		[Address(RVA = "0x23ABA34", Offset = "0x23ABA34", VA = "0x7BBCBABA34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114623C", Offset = "0x114623C")]
		private void <RequestAwakeProgress>b__169_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AAAA RID: 43690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAAA")]
		[Address(RVA = "0x23ABB50", Offset = "0x23ABB50", VA = "0x7BBCBABB50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114624C", Offset = "0x114624C")]
		private void <RequestReceiveSpecialTask>b__171_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AAAB RID: 43691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAAB")]
		[Address(RVA = "0x23ABCCC", Offset = "0x23ABCCC", VA = "0x7BBCBABCCC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114625C", Offset = "0x114625C")]
		private void <InitTokenTipsDesc>b__174_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AAAC RID: 43692 RVA: 0x0002EBA8 File Offset: 0x0002CDA8
		[Token(Token = "0x600AAAC")]
		[Address(RVA = "0x23ABE08", Offset = "0x23ABE08", VA = "0x7BBCBABE08")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114626C", Offset = "0x114626C")]
		private bool <InitTokenTipsDesc>b__174_1(BigEventTokenTipsDesc x)
		{
			return default(bool);
		}

		// Token: 0x0400AF2B RID: 44843
		[Token(Token = "0x400AF2B")]
		public const uint PropID_StoreItemsRefresh = 1U;

		// Token: 0x0400AF2C RID: 44844
		[Token(Token = "0x400AF2C")]
		public const uint PropID_PurchaseSuccess = 2U;

		// Token: 0x0400AF2D RID: 44845
		[Token(Token = "0x400AF2D")]
		public const uint PropID_GuessReqConfirm = 4U;

		// Token: 0x0400AF2E RID: 44846
		[Token(Token = "0x400AF2E")]
		public const uint PropID_SettingUpdate = 8U;

		// Token: 0x0400AF2F RID: 44847
		[Token(Token = "0x400AF2F")]
		public const uint PropID_GuessingInfoUpdate = 16U;

		// Token: 0x0400AF30 RID: 44848
		[Token(Token = "0x400AF30")]
		public const uint PropID_GuessingAwardClaimConfirm = 32U;

		// Token: 0x0400AF31 RID: 44849
		[Token(Token = "0x400AF31")]
		public const uint PropID_AwakeProgressUpdate = 64U;

		// Token: 0x0400AF32 RID: 44850
		[Token(Token = "0x400AF32")]
		public const uint PropID_CheckInStatusUpdate = 128U;

		// Token: 0x0400AF33 RID: 44851
		[Token(Token = "0x400AF33")]
		public const uint PropID_BoxCheckInUpdate = 256U;

		// Token: 0x0400AF34 RID: 44852
		[Token(Token = "0x400AF34")]
		public const uint PropID_SpTaskPlay = 512U;

		// Token: 0x0400AF35 RID: 44853
		[Token(Token = "0x400AF35")]
		private const int TASK_THRESHOLD_1 = 0;

		// Token: 0x0400AF36 RID: 44854
		[Token(Token = "0x400AF36")]
		private const int TASK_THRESHOLD_2 = 25;

		// Token: 0x0400AF37 RID: 44855
		[Token(Token = "0x400AF37")]
		private const int TASK_THRESHOLD_3 = 50;

		// Token: 0x0400AF38 RID: 44856
		[Token(Token = "0x400AF38")]
		private const int TASK_THRESHOLD_4 = 75;

		// Token: 0x0400AF39 RID: 44857
		[Token(Token = "0x400AF39")]
		public const int TASK_NUM = 3;

		// Token: 0x0400AF3A RID: 44858
		[Token(Token = "0x400AF3A")]
		[FieldOffset(Offset = "0x18")]
		private ulong m_LastReqSetttingTimeStamp;

		// Token: 0x0400AF3B RID: 44859
		[Token(Token = "0x400AF3B")]
		private const int SETTING_TIME_STAMP_INTERVAL = 60;

		// Token: 0x0400AF3C RID: 44860
		[Token(Token = "0x400AF3C")]
		private const int TITLE_CDN_TYPE_CHECKIN = 10002;

		// Token: 0x0400AF3D RID: 44861
		[Token(Token = "0x400AF3D")]
		private const int TITLE_CDN_TYPE_GUESS = 10003;

		// Token: 0x0400AF3E RID: 44862
		[Token(Token = "0x400AF3E")]
		private const int TITLE_CDN_TYPE_MAINPAGE = 10004;

		// Token: 0x0400AF3F RID: 44863
		[Token(Token = "0x400AF3F")]
		private const int TITLE_CDN_TYPE_LIVE = 10005;

		// Token: 0x0400AF40 RID: 44864
		[Token(Token = "0x400AF40")]
		private const int TITLE_CDN_TYPE_LIVE_BG = 10006;

		// Token: 0x0400AF41 RID: 44865
		[Token(Token = "0x400AF41")]
		private const int TITLE_CDN_TYPE_STORE = 10007;

		// Token: 0x0400AF42 RID: 44866
		[Token(Token = "0x400AF42")]
		private const int TITLE_CDN_TYPE_TASK = 10008;

		// Token: 0x0400AF43 RID: 44867
		[Token(Token = "0x400AF43")]
		private const int TITLE_CDN_TYPE_GUESS_WIN_AWARD = 10009;

		// Token: 0x0400AF44 RID: 44868
		[Token(Token = "0x400AF44")]
		private const int TITLE_CDN_TYPE_GUESS_LOSE_AWARD = 10010;

		// Token: 0x0400AF45 RID: 44869
		[Token(Token = "0x400AF45")]
		private const int TITLE_CDN_TYPE_WARMUP = 10011;

		// Token: 0x0400AF46 RID: 44870
		[Token(Token = "0x400AF46")]
		private const int TITLE_CDN_TYPE_STORE_BG = 10013;

		// Token: 0x0400AF47 RID: 44871
		[Token(Token = "0x400AF47")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<uint, bool> StoreTipsOnOff;

		// Token: 0x0400AF48 RID: 44872
		[Token(Token = "0x400AF48")]
		[FieldOffset(Offset = "0x28")]
		private List<LimitedEventStore> m_StoreList;

		// Token: 0x0400AF49 RID: 44873
		[Token(Token = "0x400AF49")]
		[FieldOffset(Offset = "0x30")]
		private uint m_EventID;

		// Token: 0x0400AF4A RID: 44874
		[Token(Token = "0x400AF4A")]
		[FieldOffset(Offset = "0x34")]
		private uint m_StoreType;

		// Token: 0x0400AF4B RID: 44875
		[Token(Token = "0x400AF4B")]
		[FieldOffset(Offset = "0x38")]
		private CSFFWSBoxSignInRes m_BoxSignInRes;

		// Token: 0x0400AF4C RID: 44876
		[Token(Token = "0x400AF4C")]
		[FieldOffset(Offset = "0x40")]
		private List<BigEventTokenTipsDesc> m_Token;

		// Token: 0x0400AF4D RID: 44877
		[Token(Token = "0x400AF4D")]
		[FieldOffset(Offset = "0x48")]
		private uint m_SpecialTaskIndex;

		// Token: 0x0400AF4E RID: 44878
		[Token(Token = "0x400AF4E")]
		[FieldOffset(Offset = "0x50")]
		public List<FFWSDailyTaskTextDesc> ListDailyTask;

		// Token: 0x0400AF4F RID: 44879
		[Token(Token = "0x400AF4F")]
		[FieldOffset(Offset = "0x58")]
		public List<FFWSSpecialTaskTextDesc> ListSpecialTask;

		// Token: 0x0400AF50 RID: 44880
		[Token(Token = "0x400AF50")]
		[FieldOffset(Offset = "0x60")]
		private List<ClientActivityDesc> m_ActivityDescList;

		// Token: 0x0400AF51 RID: 44881
		[Token(Token = "0x400AF51")]
		[FieldOffset(Offset = "0x68")]
		private ClientActivityDesc m_SpActivityDesc;

		// Token: 0x0400AF52 RID: 44882
		[Token(Token = "0x400AF52")]
		[FieldOffset(Offset = "0x70")]
		private FFWSSettingDesc m_SettingDesc;

		// Token: 0x0400AF53 RID: 44883
		[Token(Token = "0x400AF53")]
		[FieldOffset(Offset = "0x78")]
		public List<FFWSTeamInfoDesc> ListTeamInfo;

		// Token: 0x0400AF54 RID: 44884
		[Token(Token = "0x400AF54")]
		[FieldOffset(Offset = "0x80")]
		public List<FFWSGuessingAwardDesc> ListGuessingAwards;

		// Token: 0x0400AF55 RID: 44885
		[Token(Token = "0x400AF55")]
		[FieldOffset(Offset = "0x88")]
		public List<FFWSTeamResultsDesc> ListTeamPoints;

		// Token: 0x0400AF56 RID: 44886
		[Token(Token = "0x400AF56")]
		[FieldOffset(Offset = "0x90")]
		public uint[] ListAIPickTeam;

		// Token: 0x0400AF57 RID: 44887
		[Token(Token = "0x400AF57")]
		[FieldOffset(Offset = "0x98")]
		public uint[] ListPlayerPickTeam;

		// Token: 0x0400AF58 RID: 44888
		[Token(Token = "0x400AF58")]
		[FieldOffset(Offset = "0xA0")]
		public List<ELimitedEvent.FFWSGuessingAwardStatus> ListAwardStatus;

		// Token: 0x0400AF59 RID: 44889
		[Token(Token = "0x400AF59")]
		public const uint RoundCount = 6U;

		// Token: 0x0400AF5A RID: 44890
		[Token(Token = "0x400AF5A")]
		public const uint TeamCount = 12U;

		// Token: 0x0400AF5B RID: 44891
		[Token(Token = "0x400AF5B")]
		public const uint INVALID_TEAM_ID = 0U;

		// Token: 0x0400AF5C RID: 44892
		[Token(Token = "0x400AF5C")]
		public const int INVALID_TIME_STAMP = 0;

		// Token: 0x0400AF5D RID: 44893
		[Token(Token = "0x400AF5D")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_IsTurnTableAllSigned;

		// Token: 0x0400AF5E RID: 44894
		[Token(Token = "0x400AF5E")]
		[FieldOffset(Offset = "0xA9")]
		private bool m_HasRequested;

		// Token: 0x0400AF5F RID: 44895
		[Token(Token = "0x400AF5F")]
		[FieldOffset(Offset = "0xAA")]
		private bool m_IsCheckIn;

		// Token: 0x0400AF60 RID: 44896
		[Token(Token = "0x400AF60")]
		[FieldOffset(Offset = "0xB0")]
		private ulong m_TurntableResetTime;

		// Token: 0x0400AF61 RID: 44897
		[Token(Token = "0x400AF61")]
		[FieldOffset(Offset = "0xB8")]
		private CSGetFFWSCurProcessRes m_CurProcessRes;

		// Token: 0x0400AF62 RID: 44898
		[Token(Token = "0x400AF62")]
		[FieldOffset(Offset = "0xC0")]
		private ulong m_CurProcessPercentage;

		// Token: 0x0400AF63 RID: 44899
		[Token(Token = "0x400AF63")]
		[FieldOffset(Offset = "0xC8")]
		private ulong m_ProgressTimeLimit;

		// Token: 0x0400AF64 RID: 44900
		[Token(Token = "0x400AF64")]
		private const ulong PROGRESSTIMECD = 7200UL;

		// Token: 0x02001E53 RID: 7763
		[Token(Token = "0x2001E53")]
		public class NotifyArgsPurchase
		{
			// Token: 0x0600AAAD RID: 43693 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAAD")]
			[Address(RVA = "0x23ACF64", Offset = "0x23ACF64", VA = "0x7BBCBACF64")]
			public NotifyArgsPurchase()
			{
			}

			// Token: 0x0400AF65 RID: 44901
			[Token(Token = "0x400AF65")]
			[FieldOffset(Offset = "0x10")]
			public uint skuID;
		}

		// Token: 0x02001E54 RID: 7764
		[Token(Token = "0x2001E54")]
		private enum TaskText
		{
			// Token: 0x0400AF67 RID: 44903
			[Token(Token = "0x400AF67")]
			TaskText1 = 1,
			// Token: 0x0400AF68 RID: 44904
			[Token(Token = "0x400AF68")]
			TaskText2,
			// Token: 0x0400AF69 RID: 44905
			[Token(Token = "0x400AF69")]
			TaskText3,
			// Token: 0x0400AF6A RID: 44906
			[Token(Token = "0x400AF6A")]
			TaskText4,
			// Token: 0x0400AF6B RID: 44907
			[Token(Token = "0x400AF6B")]
			TaskText5
		}

		// Token: 0x02001E55 RID: 7765
		[Token(Token = "0x2001E55")]
		public enum GuessAwardStatus
		{
			// Token: 0x0400AF6D RID: 44909
			[Token(Token = "0x400AF6D")]
			CanSee,
			// Token: 0x0400AF6E RID: 44910
			[Token(Token = "0x400AF6E")]
			CanClaim,
			// Token: 0x0400AF6F RID: 44911
			[Token(Token = "0x400AF6F")]
			HasClaimed
		}

		// Token: 0x02001E56 RID: 7766
		[Token(Token = "0x2001E56")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC624", Offset = "0x10FC624")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600AAAF RID: 43695 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAAF")]
			[Address(RVA = "0x23ABEB8", Offset = "0x23ABEB8", VA = "0x7BBCBABEB8")]
			public <>c()
			{
			}

			// Token: 0x0600AAB0 RID: 43696 RVA: 0x0002EBC0 File Offset: 0x0002CDC0
			[Token(Token = "0x600AAB0")]
			[Address(RVA = "0x23ABEC0", Offset = "0x23ABEC0", VA = "0x7BBCBABEC0")]
			internal bool <GetActivityTime>b__48_0(BigEventOpenInfoDesc item)
			{
				return default(bool);
			}

			// Token: 0x0600AAB1 RID: 43697 RVA: 0x0002EBD8 File Offset: 0x0002CDD8
			[Token(Token = "0x600AAB1")]
			[Address(RVA = "0x23ABEF4", Offset = "0x23ABEF4", VA = "0x7BBCBABEF4")]
			internal int <GetStoreRes>b__56_1(LimitedEventStore a, LimitedEventStore b)
			{
				return 0;
			}

			// Token: 0x0600AAB2 RID: 43698 RVA: 0x0002EBF0 File Offset: 0x0002CDF0
			[Token(Token = "0x600AAB2")]
			[Address(RVA = "0x23ABF5C", Offset = "0x23ABF5C", VA = "0x7BBCBABF5C")]
			internal bool <CheckLastDay>b__158_0(BigEventOpenInfoDesc info)
			{
				return default(bool);
			}

			// Token: 0x0400AF70 RID: 44912
			[Token(Token = "0x400AF70")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelFFWS.<>c <>9;

			// Token: 0x0400AF71 RID: 44913
			[Token(Token = "0x400AF71")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<BigEventOpenInfoDesc> <>9__48_0;

			// Token: 0x0400AF72 RID: 44914
			[Token(Token = "0x400AF72")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<LimitedEventStore> <>9__56_1;

			// Token: 0x0400AF73 RID: 44915
			[Token(Token = "0x400AF73")]
			[FieldOffset(Offset = "0x18")]
			public static Predicate<BigEventOpenInfoDesc> <>9__158_0;
		}

		// Token: 0x02001E57 RID: 7767
		[Token(Token = "0x2001E57")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC634", Offset = "0x10FC634")]
		private sealed class <>c__DisplayClass58_0
		{
			// Token: 0x0600AAB3 RID: 43699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAB3")]
			[Address(RVA = "0x23A7020", Offset = "0x23A7020", VA = "0x7BBCBA7020")]
			public <>c__DisplayClass58_0()
			{
			}

			// Token: 0x0600AAB4 RID: 43700 RVA: 0x0002EC08 File Offset: 0x0002CE08
			[Token(Token = "0x600AAB4")]
			[Address(RVA = "0x23AC894", Offset = "0x23AC894", VA = "0x7BBCBAC894")]
			internal bool <GetStoreItemsList>b__0(LimitedEventStore store)
			{
				return default(bool);
			}

			// Token: 0x0400AF74 RID: 44916
			[Token(Token = "0x400AF74")]
			[FieldOffset(Offset = "0x10")]
			public uint id;
		}

		// Token: 0x02001E58 RID: 7768
		[Token(Token = "0x2001E58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC644", Offset = "0x10FC644")]
		private sealed class <>c__DisplayClass59_0
		{
			// Token: 0x0600AAB5 RID: 43701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAB5")]
			[Address(RVA = "0x23A753C", Offset = "0x23A753C", VA = "0x7BBCBA753C")]
			public <>c__DisplayClass59_0()
			{
			}

			// Token: 0x0600AAB6 RID: 43702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAB6")]
			[Address(RVA = "0x23AC8E0", Offset = "0x23AC8E0", VA = "0x7BBCBAC8E0")]
			internal void <RequesePurchase>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600AAB7 RID: 43703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAB7")]
			[Address(RVA = "0x23ACF6C", Offset = "0x23ACF6C", VA = "0x7BBCBACF6C")]
			internal void <RequesePurchase>b__1()
			{
			}

			// Token: 0x0400AF75 RID: 44917
			[Token(Token = "0x400AF75")]
			[FieldOffset(Offset = "0x10")]
			public BigEventStoreCommodityDesc desc;

			// Token: 0x0400AF76 RID: 44918
			[Token(Token = "0x400AF76")]
			[FieldOffset(Offset = "0x18")]
			public uint cnt;

			// Token: 0x0400AF77 RID: 44919
			[Token(Token = "0x400AF77")]
			[FieldOffset(Offset = "0x20")]
			public UIModelFFWS <>4__this;

			// Token: 0x0400AF78 RID: 44920
			[Token(Token = "0x400AF78")]
			[FieldOffset(Offset = "0x28")]
			public Action <>9__1;
		}

		// Token: 0x02001E59 RID: 7769
		[Token(Token = "0x2001E59")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC654", Offset = "0x10FC654")]
		private sealed class <>c__DisplayClass106_0
		{
			// Token: 0x0600AAB8 RID: 43704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAB8")]
			[Address(RVA = "0x23A89F8", Offset = "0x23A89F8", VA = "0x7BBCBA89F8")]
			public <>c__DisplayClass106_0()
			{
			}

			// Token: 0x0600AAB9 RID: 43705 RVA: 0x0002EC20 File Offset: 0x0002CE20
			[Token(Token = "0x600AAB9")]
			[Address(RVA = "0x23ABF90", Offset = "0x23ABF90", VA = "0x7BBCBABF90")]
			internal bool <GetTeamInfoByTeamId>b__0(FFWSTeamInfoDesc x)
			{
				return default(bool);
			}

			// Token: 0x0400AF79 RID: 44921
			[Token(Token = "0x400AF79")]
			[FieldOffset(Offset = "0x10")]
			public uint teamId;
		}

		// Token: 0x02001E5A RID: 7770
		[Token(Token = "0x2001E5A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC664", Offset = "0x10FC664")]
		private sealed class <>c__DisplayClass108_0
		{
			// Token: 0x0600AABA RID: 43706 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AABA")]
			[Address(RVA = "0x23A8B84", Offset = "0x23A8B84", VA = "0x7BBCBA8B84")]
			public <>c__DisplayClass108_0()
			{
			}

			// Token: 0x0600AABB RID: 43707 RVA: 0x0002EC38 File Offset: 0x0002CE38
			[Token(Token = "0x600AABB")]
			[Address(RVA = "0x23ABFCC", Offset = "0x23ABFCC", VA = "0x7BBCBABFCC")]
			internal bool <GetTeamPointAt>b__0(FFWSTeamResultsDesc x)
			{
				return default(bool);
			}

			// Token: 0x0400AF7A RID: 44922
			[Token(Token = "0x400AF7A")]
			[FieldOffset(Offset = "0x10")]
			public uint teamId;
		}

		// Token: 0x02001E5B RID: 7771
		[Token(Token = "0x2001E5B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC674", Offset = "0x10FC674")]
		private sealed class <>c__DisplayClass114_0
		{
			// Token: 0x0600AABC RID: 43708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AABC")]
			[Address(RVA = "0x23A8EAC", Offset = "0x23A8EAC", VA = "0x7BBCBA8EAC")]
			public <>c__DisplayClass114_0()
			{
			}

			// Token: 0x0600AABD RID: 43709 RVA: 0x0002EC50 File Offset: 0x0002CE50
			[Token(Token = "0x600AABD")]
			[Address(RVA = "0x23AC008", Offset = "0x23AC008", VA = "0x7BBCBAC008")]
			internal bool <GetAwardListByRound>b__0(FFWSGuessingAwardDesc x)
			{
				return default(bool);
			}

			// Token: 0x0400AF7B RID: 44923
			[Token(Token = "0x400AF7B")]
			[FieldOffset(Offset = "0x10")]
			public uint roundIndex;

			// Token: 0x0400AF7C RID: 44924
			[Token(Token = "0x400AF7C")]
			[FieldOffset(Offset = "0x14")]
			public ELimitedEvent.FFWSGuessingAwardType awardType;
		}

		// Token: 0x02001E5C RID: 7772
		[Token(Token = "0x2001E5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC684", Offset = "0x10FC684")]
		private sealed class <>c__DisplayClass159_0
		{
			// Token: 0x0600AABE RID: 43710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AABE")]
			[Address(RVA = "0x23AA810", Offset = "0x23AA810", VA = "0x7BBCBAA810")]
			public <>c__DisplayClass159_0()
			{
			}

			// Token: 0x0600AABF RID: 43711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AABF")]
			[Address(RVA = "0x23AC05C", Offset = "0x23AC05C", VA = "0x7BBCBAC05C")]
			internal void <GetFFWSSettingRes>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AF7D RID: 44925
			[Token(Token = "0x400AF7D")]
			[FieldOffset(Offset = "0x10")]
			public UIModelFFWS <>4__this;

			// Token: 0x0400AF7E RID: 44926
			[Token(Token = "0x400AF7E")]
			[FieldOffset(Offset = "0x18")]
			public ulong currentTimeStamp;
		}

		// Token: 0x02001E5D RID: 7773
		[Token(Token = "0x2001E5D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC694", Offset = "0x10FC694")]
		private sealed class <>c__DisplayClass172_0
		{
			// Token: 0x0600AAC0 RID: 43712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAC0")]
			[Address(RVA = "0x23AAEE0", Offset = "0x23AAEE0", VA = "0x7BBCBAAEE0")]
			public <>c__DisplayClass172_0()
			{
			}

			// Token: 0x0600AAC1 RID: 43713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAC1")]
			[Address(RVA = "0x23AC21C", Offset = "0x23AC21C", VA = "0x7BBCBAC21C")]
			internal void <RequestGuess>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AF7F RID: 44927
			[Token(Token = "0x400AF7F")]
			[FieldOffset(Offset = "0x10")]
			public UIModelFFWS <>4__this;

			// Token: 0x0400AF80 RID: 44928
			[Token(Token = "0x400AF80")]
			[FieldOffset(Offset = "0x18")]
			public uint roundIndex;

			// Token: 0x0400AF81 RID: 44929
			[Token(Token = "0x400AF81")]
			[FieldOffset(Offset = "0x1C")]
			public uint teamId;
		}

		// Token: 0x02001E5E RID: 7774
		[Token(Token = "0x2001E5E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC6A4", Offset = "0x10FC6A4")]
		private sealed class <>c__DisplayClass173_0
		{
			// Token: 0x0600AAC2 RID: 43714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAC2")]
			[Address(RVA = "0x23AB0F4", Offset = "0x23AB0F4", VA = "0x7BBCBAB0F4")]
			public <>c__DisplayClass173_0()
			{
			}

			// Token: 0x0600AAC3 RID: 43715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAC3")]
			[Address(RVA = "0x23AC3C4", Offset = "0x23AC3C4", VA = "0x7BBCBAC3C4")]
			internal void <RequestClaimGuessAward>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AF82 RID: 44930
			[Token(Token = "0x400AF82")]
			[FieldOffset(Offset = "0x10")]
			public UIModelFFWS <>4__this;

			// Token: 0x0400AF83 RID: 44931
			[Token(Token = "0x400AF83")]
			[FieldOffset(Offset = "0x18")]
			public uint roundIndex;
		}
	}
}
