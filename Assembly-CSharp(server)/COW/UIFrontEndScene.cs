using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002076 RID: 8310
	[Token(Token = "0x2002076")]
	internal class UIFrontEndScene : UICOWBaseScene
	{
		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x0600B91A RID: 47386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBB")]
		private UIModelClan ModelClan
		{
			[Token(Token = "0x600B91A")]
			[Address(RVA = "0x15A0F08", Offset = "0x15A0F08", VA = "0x7BBBDA0F08")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x0600B91B RID: 47387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBC")]
		private UIModelInvitation ModelInvitation
		{
			[Token(Token = "0x600B91B")]
			[Address(RVA = "0x15A0FA4", Offset = "0x15A0FA4", VA = "0x7BBBDA0FA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B91C RID: 47388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B91C")]
		[Address(RVA = "0x15A1040", Offset = "0x15A1040", VA = "0x7BBBDA1040")]
		public void DisableBgCamera()
		{
		}

		// Token: 0x0600B91D RID: 47389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B91D")]
		[Address(RVA = "0x15A10E0", Offset = "0x15A10E0", VA = "0x7BBBDA10E0")]
		public void Show()
		{
		}

		// Token: 0x0600B91E RID: 47390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B91E")]
		[Address(RVA = "0x15A3798", Offset = "0x15A3798", VA = "0x7BBBDA3798")]
		private void RequestEmote()
		{
		}

		// Token: 0x0600B91F RID: 47391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B91F")]
		[Address(RVA = "0x15A3B70", Offset = "0x15A3B70", VA = "0x7BBBDA3B70")]
		private void OnApplicationPauseEvent(object[] parameters)
		{
		}

		// Token: 0x0600B920 RID: 47392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B920")]
		[Address(RVA = "0x15A3CDC", Offset = "0x15A3CDC", VA = "0x7BBBDA3CDC")]
		public static void ProcessOpenedByUrl()
		{
		}

		// Token: 0x0600B921 RID: 47393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B921")]
		private T GetParam<T>(object[] param, int index)
		{
			return null;
		}

		// Token: 0x0600B922 RID: 47394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B922")]
		[Address(RVA = "0x15A4038", Offset = "0x15A4038", VA = "0x7BBBDA4038")]
		private void OnDeepLink(params object[] param)
		{
		}

		// Token: 0x0600B923 RID: 47395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B923")]
		[Address(RVA = "0x15A4768", Offset = "0x15A4768", VA = "0x7BBBDA4768")]
		private void OnDeepLink_GroupInvite(string group_id, string region, string secret_code)
		{
		}

		// Token: 0x0600B924 RID: 47396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B924")]
		[Address(RVA = "0x15A4AD4", Offset = "0x15A4AD4", VA = "0x7BBBDA4AD4")]
		private void OnDeepLink_Lobby()
		{
		}

		// Token: 0x0600B925 RID: 47397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B925")]
		[Address(RVA = "0x15A4C80", Offset = "0x15A4C80", VA = "0x7BBBDA4C80")]
		private void OnDeepLink_Reunion(string uid)
		{
		}

		// Token: 0x0600B926 RID: 47398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B926")]
		[Address(RVA = "0x15A4D5C", Offset = "0x15A4D5C", VA = "0x7BBBDA4D5C")]
		private void OnDeepLink_LocateClan(string clanId)
		{
		}

		// Token: 0x0600B927 RID: 47399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B927")]
		[Address(RVA = "0x15A4E38", Offset = "0x15A4E38", VA = "0x7BBBDA4E38")]
		private void OnDeepLink_LocateRoom(uint roomType, string roomId)
		{
		}

		// Token: 0x0600B928 RID: 47400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B928")]
		[Address(RVA = "0x15A46DC", Offset = "0x15A46DC", VA = "0x7BBBDA46DC")]
		private void OnDeepLink_Gacha()
		{
		}

		// Token: 0x0600B929 RID: 47401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B929")]
		[Address(RVA = "0x15A4650", Offset = "0x15A4650", VA = "0x7BBBDA4650")]
		private void OnDeepLink_ElitePass()
		{
		}

		// Token: 0x0600B92A RID: 47402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B92A")]
		[Address(RVA = "0x15A4580", Offset = "0x15A4580", VA = "0x7BBBDA4580")]
		private void OnDeepLink_CharactersNew()
		{
		}

		// Token: 0x0600B92B RID: 47403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B92B")]
		[Address(RVA = "0x15A4BF4", Offset = "0x15A4BF4", VA = "0x7BBBDA4BF4")]
		private void OnDeepLink_RebateCard()
		{
		}

		// Token: 0x0600B92C RID: 47404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B92C")]
		[Address(RVA = "0x15A4A20", Offset = "0x15A4A20", VA = "0x7BBBDA4A20")]
		private void OnDeepLink_IAPBundle()
		{
		}

		// Token: 0x0600B92D RID: 47405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B92D")]
		[Address(RVA = "0x15A4AC0", Offset = "0x15A4AC0", VA = "0x7BBBDA4AC0")]
		private void OnDeepLink_Mail()
		{
		}

		// Token: 0x0600B92E RID: 47406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B92E")]
		[Address(RVA = "0x15A4B54", Offset = "0x15A4B54", VA = "0x7BBBDA4B54")]
		private void OnDeeplink_Navigate(uint pos, string param)
		{
		}

		// Token: 0x0600B92F RID: 47407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B92F")]
		[Address(RVA = "0x15A4FE0", Offset = "0x15A4FE0", VA = "0x7BBBDA4FE0")]
		private void OnDeepLink_Goliath(string groupID)
		{
		}

		// Token: 0x0600B930 RID: 47408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B930")]
		[Address(RVA = "0x15A5120", Offset = "0x15A5120", VA = "0x7BBBDA5120")]
		private void OnDeepLink_SuperCar(string id)
		{
		}

		// Token: 0x0600B931 RID: 47409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B931")]
		[Address(RVA = "0x15A51E4", Offset = "0x15A51E4", VA = "0x7BBBDA51E4")]
		private void ShowMessageBox(object[] data)
		{
		}

		// Token: 0x0600B932 RID: 47410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B932")]
		[Address(RVA = "0x15A5404", Offset = "0x15A5404", VA = "0x7BBBDA5404")]
		private void ShowIAPMessageBox(object[] data)
		{
		}

		// Token: 0x0600B933 RID: 47411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B933")]
		[Address(RVA = "0x15A5648", Offset = "0x15A5648", VA = "0x7BBBDA5648")]
		private void OnShowDownloadPopup(object[] data)
		{
		}

		// Token: 0x0600B934 RID: 47412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B934")]
		[Address(RVA = "0x15A5DC4", Offset = "0x15A5DC4", VA = "0x7BBBDA5DC4")]
		private void OnShowDownloadConfirmPopup(object[] data)
		{
		}

		// Token: 0x0600B935 RID: 47413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B935")]
		[Address(RVA = "0x15A63DC", Offset = "0x15A63DC", VA = "0x7BBBDA63DC")]
		private void ShowCommonRewardWnd(object[] data)
		{
		}

		// Token: 0x0600B936 RID: 47414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B936")]
		[Address(RVA = "0x15A6548", Offset = "0x15A6548", VA = "0x7BBBDA6548")]
		private void ShowMVPRewardWnd(object[] data)
		{
		}

		// Token: 0x0600B937 RID: 47415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B937")]
		[Address(RVA = "0x15A66B4", Offset = "0x15A66B4", VA = "0x7BBBDA66B4")]
		private void ShowDiceGameBranchWnd(object[] data)
		{
		}

		// Token: 0x0600B938 RID: 47416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B938")]
		[Address(RVA = "0x15A35DC", Offset = "0x15A35DC", VA = "0x7BBBDA35DC")]
		private Transform FindBGUIRoot()
		{
			return null;
		}

		// Token: 0x0600B939 RID: 47417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B939")]
		[Address(RVA = "0x15A67E4", Offset = "0x15A67E4", VA = "0x7BBBDA67E4")]
		private GameObject FindUI3DRoot()
		{
			return null;
		}

		// Token: 0x0600B93A RID: 47418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B93A")]
		[Address(RVA = "0x15A6830", Offset = "0x15A6830", VA = "0x7BBBDA6830", Slot = "7")]
		protected override Transform FindUIRoot()
		{
			return null;
		}

		// Token: 0x0600B93B RID: 47419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B93B")]
		[Address(RVA = "0x15A3640", Offset = "0x15A3640", VA = "0x7BBBDA3640")]
		private UI3DObjectHelper FindUI3DRootHelper()
		{
			return null;
		}

		// Token: 0x0600B93C RID: 47420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B93C")]
		[Address(RVA = "0x15A36E4", Offset = "0x15A36E4", VA = "0x7BBBDA36E4")]
		private Camera FindUI3DCamera()
		{
			return null;
		}

		// Token: 0x0600B93D RID: 47421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B93D")]
		[Address(RVA = "0x15A69CC", Offset = "0x15A69CC", VA = "0x7BBBDA69CC", Slot = "4")]
		public override void Destory()
		{
		}

		// Token: 0x0600B93E RID: 47422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B93E")]
		[Address(RVA = "0x15A6A7C", Offset = "0x15A6A7C", VA = "0x7BBBDA6A7C", Slot = "9")]
		protected override void OnDestory()
		{
		}

		// Token: 0x0600B93F RID: 47423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B93F")]
		[Address(RVA = "0x15A3A58", Offset = "0x15A3A58", VA = "0x7BBBDA3A58")]
		private void CheckReconnectInfo()
		{
		}

		// Token: 0x0600B940 RID: 47424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B940")]
		[Address(RVA = "0x15A8A70", Offset = "0x15A8A70", VA = "0x7BBBDA8A70")]
		private void ClearReconnectInfo()
		{
		}

		// Token: 0x0600B941 RID: 47425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B941")]
		[Address(RVA = "0x15A8B34", Offset = "0x15A8B34", VA = "0x7BBBDA8B34")]
		private void OnLastBattleTimeOut()
		{
		}

		// Token: 0x0600B942 RID: 47426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B942")]
		[Address(RVA = "0x15A8C70", Offset = "0x15A8C70", VA = "0x7BBBDA8C70")]
		private void OnLastBattleNotify(params object[] data)
		{
		}

		// Token: 0x0600B943 RID: 47427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B943")]
		[Address(RVA = "0x15A8DD8", Offset = "0x15A8DD8", VA = "0x7BBBDA8DD8")]
		private void StartReconnectToGame()
		{
		}

		// Token: 0x0600B944 RID: 47428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B944")]
		[Address(RVA = "0x15A8E88", Offset = "0x15A8E88", VA = "0x7BBBDA8E88")]
		private void OnOpenRoomList(object[] data)
		{
		}

		// Token: 0x0600B945 RID: 47429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B945")]
		[Address(RVA = "0x15A8FC0", Offset = "0x15A8FC0", VA = "0x7BBBDA8FC0")]
		private void OnOpenCustomRoom(object[] data)
		{
		}

		// Token: 0x0600B946 RID: 47430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B946")]
		[Address(RVA = "0x15A9470", Offset = "0x15A9470", VA = "0x7BBBDA9470")]
		private void OnCloseCustomRoom(object[] data)
		{
		}

		// Token: 0x0600B947 RID: 47431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B947")]
		[Address(RVA = "0x15A9510", Offset = "0x15A9510", VA = "0x7BBBDA9510")]
		private void EquipmentTweenTip(params object[] data)
		{
		}

		// Token: 0x0600B948 RID: 47432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B948")]
		[Address(RVA = "0x15A9894", Offset = "0x15A9894", VA = "0x7BBBDA9894")]
		private void StopMatchMaking()
		{
		}

		// Token: 0x0600B949 RID: 47433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B949")]
		[Address(RVA = "0x15A9944", Offset = "0x15A9944", VA = "0x7BBBDA9944")]
		private void OnStartMatchMaking(params object[] data)
		{
		}

		// Token: 0x0600B94A RID: 47434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B94A")]
		[Address(RVA = "0x15A9C8C", Offset = "0x15A9C8C", VA = "0x7BBBDA9C8C")]
		private void ClearEstimateTime()
		{
		}

		// Token: 0x0600B94B RID: 47435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B94B")]
		[Address(RVA = "0x15A9C94", Offset = "0x15A9C94", VA = "0x7BBBDA9C94")]
		public void OnOpenPopMenu(params object[] data)
		{
		}

		// Token: 0x0600B94C RID: 47436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B94C")]
		[Address(RVA = "0x15A9EB8", Offset = "0x15A9EB8", VA = "0x7BBBDA9EB8")]
		public void OnOpenBriefBox(params object[] data)
		{
		}

		// Token: 0x0600B94D RID: 47437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B94D")]
		[Address(RVA = "0x15AA060", Offset = "0x15AA060", VA = "0x7BBBDAA060")]
		public void OnOpenTips(params object[] data)
		{
		}

		// Token: 0x0600B94E RID: 47438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B94E")]
		[Address(RVA = "0x15AA5A0", Offset = "0x15AA5A0", VA = "0x7BBBDAA5A0")]
		public void OnOpenTweenTips(params object[] data)
		{
		}

		// Token: 0x0600B94F RID: 47439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B94F")]
		[Address(RVA = "0x15AA678", Offset = "0x15AA678", VA = "0x7BBBDAA678")]
		private void OnGroupStartNtf(params object[] data)
		{
		}

		// Token: 0x0600B950 RID: 47440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B950")]
		[Address(RVA = "0x15AA9C0", Offset = "0x15AA9C0", VA = "0x7BBBDAA9C0")]
		private void OnEndMatchMaking(params object[] data)
		{
		}

		// Token: 0x0600B951 RID: 47441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B951")]
		[Address(RVA = "0x15AACC4", Offset = "0x15AACC4", VA = "0x7BBBDAACC4")]
		private void OnStopGroupMatchMaking(params object[] data)
		{
		}

		// Token: 0x0600B952 RID: 47442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B952")]
		[Address(RVA = "0x15AACC8", Offset = "0x15AACC8", VA = "0x7BBBDAACC8")]
		private void OnLobbyTCPDisconnected(params object[] data)
		{
		}

		// Token: 0x0600B953 RID: 47443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B953")]
		[Address(RVA = "0x15AAB6C", Offset = "0x15AAB6C", VA = "0x7BBBDAAB6C")]
		private void CloseMatchmaking()
		{
		}

		// Token: 0x0600B954 RID: 47444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B954")]
		[Address(RVA = "0x15AB064", Offset = "0x15AB064", VA = "0x7BBBDAB064")]
		private void OpenFriendWindow(params object[] data)
		{
		}

		// Token: 0x0600B955 RID: 47445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B955")]
		[Address(RVA = "0x15AB26C", Offset = "0x15AB26C", VA = "0x7BBBDAB26C")]
		private void OpenFriendRequestWindow(params object[] data)
		{
		}

		// Token: 0x0600B956 RID: 47446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B956")]
		[Address(RVA = "0x15AB2DC", Offset = "0x15AB2DC", VA = "0x7BBBDAB2DC")]
		private void OpenFriendCallbackWindow(params object[] data)
		{
		}

		// Token: 0x0600B957 RID: 47447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B957")]
		[Address(RVA = "0x15AB34C", Offset = "0x15AB34C", VA = "0x7BBBDAB34C")]
		private void OpenFriendCallbackAddFriendWindow(params object[] data)
		{
		}

		// Token: 0x0600B958 RID: 47448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B958")]
		[Address(RVA = "0x15AB494", Offset = "0x15AB494", VA = "0x7BBBDAB494")]
		private void OpenFriendWindow_Reunion(params object[] data)
		{
		}

		// Token: 0x0600B959 RID: 47449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B959")]
		[Address(RVA = "0x15AB69C", Offset = "0x15AB69C", VA = "0x7BBBDAB69C")]
		private void OpenFriendWindow_Relationship(params object[] data)
		{
		}

		// Token: 0x0600B95A RID: 47450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B95A")]
		[Address(RVA = "0x15AB780", Offset = "0x15AB780", VA = "0x7BBBDAB780")]
		private void OnServiceOff(params object[] data)
		{
		}

		// Token: 0x0600B95B RID: 47451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B95B")]
		[Address(RVA = "0x15AB828", Offset = "0x15AB828", VA = "0x7BBBDAB828")]
		private void OpenMallWindow(params object[] data)
		{
		}

		// Token: 0x0600B95C RID: 47452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B95C")]
		[Address(RVA = "0x15ABDB4", Offset = "0x15ABDB4", VA = "0x7BBBDABDB4")]
		private void OpenPetWindow(params object[] data)
		{
		}

		// Token: 0x0600B95D RID: 47453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B95D")]
		[Address(RVA = "0x15ABF18", Offset = "0x15ABF18", VA = "0x7BBBDABF18")]
		private void OpenLiveTvWindow(params object[] data)
		{
		}

		// Token: 0x0600B95E RID: 47454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B95E")]
		[Address(RVA = "0x15AC1D0", Offset = "0x15AC1D0", VA = "0x7BBBDAC1D0")]
		private void OpenLeaderBoard(object[] data)
		{
		}

		// Token: 0x0600B95F RID: 47455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B95F")]
		[Address(RVA = "0x15AC37C", Offset = "0x15AC37C", VA = "0x7BBBDAC37C")]
		private void OpenAvatarProfile(object[] data)
		{
		}

		// Token: 0x0600B960 RID: 47456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B960")]
		[Address(RVA = "0x15AC554", Offset = "0x15AC554", VA = "0x7BBBDAC554")]
		private void OpenAvatarAwaken(object[] data)
		{
		}

		// Token: 0x0600B961 RID: 47457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B961")]
		[Address(RVA = "0x15AC758", Offset = "0x15AC758", VA = "0x7BBBDAC758")]
		private void OpenCollection(object[] data)
		{
		}

		// Token: 0x0600B962 RID: 47458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B962")]
		[Address(RVA = "0x15AC8BC", Offset = "0x15AC8BC", VA = "0x7BBBDAC8BC")]
		private void OpenGacha(object[] data)
		{
		}

		// Token: 0x0600B963 RID: 47459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B963")]
		[Address(RVA = "0x15ACAE0", Offset = "0x15ACAE0", VA = "0x7BBBDACAE0")]
		private void OpenForge(object[] data)
		{
		}

		// Token: 0x0600B964 RID: 47460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B964")]
		[Address(RVA = "0x15ACD78", Offset = "0x15ACD78", VA = "0x7BBBDACD78")]
		private void OpenPaymentBundleDialog(object[] data)
		{
		}

		// Token: 0x0600B965 RID: 47461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B965")]
		[Address(RVA = "0x15ACEE8", Offset = "0x15ACEE8", VA = "0x7BBBDACEE8")]
		private void PopupNextGiftRewards(object[] data)
		{
		}

		// Token: 0x0600B966 RID: 47462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B966")]
		[Address(RVA = "0x15ACF70", Offset = "0x15ACF70", VA = "0x7BBBDACF70")]
		private void OnUILobbyBGSwitch(object[] data)
		{
		}

		// Token: 0x0600B967 RID: 47463 RVA: 0x00034DD0 File Offset: 0x00032FD0
		[Token(Token = "0x600B967")]
		[Address(RVA = "0x15AD380", Offset = "0x15AD380", VA = "0x7BBBDAD380")]
		public bool IsReconnecting()
		{
			return default(bool);
		}

		// Token: 0x0600B968 RID: 47464 RVA: 0x00034DE8 File Offset: 0x00032FE8
		[Token(Token = "0x600B968")]
		[Address(RVA = "0x15A97A8", Offset = "0x15A97A8", VA = "0x7BBBDA97A8")]
		public bool IsMatchMakingLoading()
		{
			return default(bool);
		}

		// Token: 0x0600B969 RID: 47465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B969")]
		[Address(RVA = "0x15AD390", Offset = "0x15AD390", VA = "0x7BBBDAD390")]
		private void OnGroupErr(params object[] data)
		{
		}

		// Token: 0x0600B96A RID: 47466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B96A")]
		[Address(RVA = "0x15AD394", Offset = "0x15AD394", VA = "0x7BBBDAD394")]
		private void SetBackground()
		{
		}

		// Token: 0x0600B96B RID: 47467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B96B")]
		[Address(RVA = "0x15AD604", Offset = "0x15AD604", VA = "0x7BBBDAD604")]
		public void ChangeCurrentBackGround(EFrontendBGType uiType)
		{
		}

		// Token: 0x0600B96C RID: 47468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B96C")]
		[Address(RVA = "0x15AD7FC", Offset = "0x15AD7FC", VA = "0x7BBBDAD7FC")]
		public void SetBackGroundMask(bool is_show)
		{
		}

		// Token: 0x0600B96D RID: 47469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B96D")]
		[Address(RVA = "0x15AD84C", Offset = "0x15AD84C", VA = "0x7BBBDAD84C")]
		private void SetCDNBackground()
		{
		}

		// Token: 0x0600B96E RID: 47470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B96E")]
		public void ChangeTemplateBg<T>(ResourceID resid, Vector3 worldpos, int width, int height)
		{
		}

		// Token: 0x0600B96F RID: 47471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B96F")]
		[Address(RVA = "0x15ADBC8", Offset = "0x15ADBC8", VA = "0x7BBBDADBC8")]
		public void ChangeTemplateBg(Texture texture, Vector3 worldpos, int width, int height)
		{
		}

		// Token: 0x0600B970 RID: 47472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B970")]
		[Address(RVA = "0x15ADFC4", Offset = "0x15ADFC4", VA = "0x7BBBDADFC4")]
		private void SetCDNBackgroundByURL(params object[] data)
		{
		}

		// Token: 0x0600B971 RID: 47473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B971")]
		[Address(RVA = "0x15AE1B0", Offset = "0x15AE1B0", VA = "0x7BBBDAE1B0")]
		private void SetCDNBackgroundSize(params object[] data)
		{
		}

		// Token: 0x0600B972 RID: 47474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B972")]
		[Address(RVA = "0x15AD984", Offset = "0x15AD984", VA = "0x7BBBDAD984")]
		private void OnGetAdUrl(params object[] data)
		{
		}

		// Token: 0x0600B973 RID: 47475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B973")]
		[Address(RVA = "0x15AE2D8", Offset = "0x15AE2D8", VA = "0x7BBBDAE2D8")]
		private void OnOpenProfile(object[] data)
		{
		}

		// Token: 0x0600B974 RID: 47476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B974")]
		[Address(RVA = "0x15AE808", Offset = "0x15AE808", VA = "0x7BBBDAE808")]
		private void OnOpenAvatarWindow(object[] data)
		{
		}

		// Token: 0x0600B975 RID: 47477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B975")]
		[Address(RVA = "0x15AE9A4", Offset = "0x15AE9A4", VA = "0x7BBBDAE9A4")]
		private void OnOpenMapPanel(object[] data)
		{
		}

		// Token: 0x0600B976 RID: 47478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B976")]
		[Address(RVA = "0x15AEBA8", Offset = "0x15AEBA8", VA = "0x7BBBDAEBA8")]
		private void OnOpenGroup(object[] data)
		{
		}

		// Token: 0x0600B977 RID: 47479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B977")]
		[Address(RVA = "0x15AF04C", Offset = "0x15AF04C", VA = "0x7BBBDAF04C")]
		private void OnGroupCreateSuccess(params object[] param)
		{
		}

		// Token: 0x0600B978 RID: 47480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B978")]
		[Address(RVA = "0x15AF050", Offset = "0x15AF050", VA = "0x7BBBDAF050")]
		private void OpenGroupUI()
		{
		}

		// Token: 0x0600B979 RID: 47481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B979")]
		[Address(RVA = "0x15AF054", Offset = "0x15AF054", VA = "0x7BBBDAF054")]
		private void OnJoinNtf(params object[] data)
		{
		}

		// Token: 0x0600B97A RID: 47482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B97A")]
		[Address(RVA = "0x15AF058", Offset = "0x15AF058", VA = "0x7BBBDAF058")]
		private void OnLeaveNtf(params object[] data)
		{
		}

		// Token: 0x0600B97B RID: 47483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B97B")]
		[Address(RVA = "0x15AF4B8", Offset = "0x15AF4B8", VA = "0x7BBBDAF4B8")]
		public void OnLeaveGroup()
		{
		}

		// Token: 0x0600B97C RID: 47484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B97C")]
		[Address(RVA = "0x15AF56C", Offset = "0x15AF56C", VA = "0x7BBBDAF56C")]
		private void OnDismissNtf(params object[] data)
		{
		}

		// Token: 0x0600B97D RID: 47485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B97D")]
		[Address(RVA = "0x15AFAC4", Offset = "0x15AFAC4", VA = "0x7BBBDAFAC4")]
		private void OnInviteNtf(params object[] data)
		{
		}

		// Token: 0x0600B97E RID: 47486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B97E")]
		[Address(RVA = "0x15AFD00", Offset = "0x15AFD00", VA = "0x7BBBDAFD00")]
		private void OnJoinRequestNtf(params object[] data)
		{
		}

		// Token: 0x0600B97F RID: 47487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B97F")]
		[Address(RVA = "0x15AFD90", Offset = "0x15AFD90", VA = "0x7BBBDAFD90")]
		private void ProcessInviteTipImmediately(params object[] data)
		{
		}

		// Token: 0x0600B980 RID: 47488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B980")]
		[Address(RVA = "0x15AFC24", Offset = "0x15AFC24", VA = "0x7BBBDAFC24")]
		private void ProcessInviteTip(params object[] data)
		{
		}

		// Token: 0x0600B981 RID: 47489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B981")]
		[Address(RVA = "0x15B0A40", Offset = "0x15B0A40", VA = "0x7BBBDB0A40")]
		private void SendInviteNotiReplaceLog(object data)
		{
		}

		// Token: 0x0600B982 RID: 47490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B982")]
		[Address(RVA = "0x15B0A44", Offset = "0x15B0A44", VA = "0x7BBBDB0A44")]
		private void OpenInvitationTipsBox(params object[] args)
		{
		}

		// Token: 0x0600B983 RID: 47491 RVA: 0x00034E00 File Offset: 0x00033000
		[Token(Token = "0x600B983")]
		[Address(RVA = "0x15B0C04", Offset = "0x15B0C04", VA = "0x7BBBDB0C04")]
		private uint GetInviteTipsType(object arg)
		{
			return 0U;
		}

		// Token: 0x0600B984 RID: 47492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B984")]
		[Address(RVA = "0x15AF86C", Offset = "0x15AF86C", VA = "0x7BBBDAF86C")]
		private void ShowGroupMessageBox(string details = "", string title = "", [Optional] Action cb)
		{
		}

		// Token: 0x0600B985 RID: 47493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B985")]
		[Address(RVA = "0x15B0D1C", Offset = "0x15B0D1C", VA = "0x7BBBDB0D1C")]
		private void OnOpenVault(params object[] data)
		{
		}

		// Token: 0x0600B986 RID: 47494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B986")]
		[Address(RVA = "0x15B1038", Offset = "0x15B1038", VA = "0x7BBBDB1038")]
		private void OnOpenClanSearchById(params object[] param)
		{
		}

		// Token: 0x0600B987 RID: 47495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B987")]
		[Address(RVA = "0x15B13C0", Offset = "0x15B13C0", VA = "0x7BBBDB13C0")]
		private void OnOpenClan(params object[] param)
		{
		}

		// Token: 0x0600B988 RID: 47496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B988")]
		[Address(RVA = "0x15B18A8", Offset = "0x15B18A8", VA = "0x7BBBDB18A8")]
		private void OnOpenDebtWindow(params object[] dat)
		{
		}

		// Token: 0x0600B989 RID: 47497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B989")]
		[Address(RVA = "0x15B19D0", Offset = "0x15B19D0", VA = "0x7BBBDB19D0")]
		private void OnOpenConnectionReport(params object[] param)
		{
		}

		// Token: 0x0600B98A RID: 47498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B98A")]
		[Address(RVA = "0x15B1B10", Offset = "0x15B1B10", VA = "0x7BBBDB1B10")]
		private void OnClanCreated(params object[] param)
		{
		}

		// Token: 0x0600B98B RID: 47499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B98B")]
		[Address(RVA = "0x15B1D3C", Offset = "0x15B1D3C", VA = "0x7BBBDB1D3C")]
		private void ShowHttpRequestErrorMessage(params object[] param)
		{
		}

		// Token: 0x0600B98C RID: 47500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B98C")]
		[Address(RVA = "0x15B1F18", Offset = "0x15B1F18", VA = "0x7BBBDB1F18")]
		private void OnLobby3DObjectVisibleChange(params object[] data)
		{
		}

		// Token: 0x0600B98D RID: 47501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B98D")]
		[Address(RVA = "0x15B22A8", Offset = "0x15B22A8", VA = "0x7BBBDB22A8")]
		private void SetBG(params object[] data)
		{
		}

		// Token: 0x0600B98E RID: 47502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B98E")]
		[Address(RVA = "0x15B2560", Offset = "0x15B2560", VA = "0x7BBBDB2560")]
		private void SetCDNBG(params object[] data)
		{
		}

		// Token: 0x0600B98F RID: 47503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B98F")]
		[Address(RVA = "0x15B23D8", Offset = "0x15B23D8", VA = "0x7BBBDB23D8")]
		private void PushBgStack(EFrontendBGType type)
		{
		}

		// Token: 0x0600B990 RID: 47504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B990")]
		[Address(RVA = "0x15B247C", Offset = "0x15B247C", VA = "0x7BBBDB247C")]
		private void PopBgStack(EFrontendBGType type, bool needShow = false)
		{
		}

		// Token: 0x0600B991 RID: 47505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B991")]
		[Address(RVA = "0x15B2818", Offset = "0x15B2818", VA = "0x7BBBDB2818")]
		private void PlayBGM(params object[] data)
		{
		}

		// Token: 0x0600B992 RID: 47506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B992")]
		[Address(RVA = "0x15B2A88", Offset = "0x15B2A88", VA = "0x7BBBDB2A88")]
		public void ContinuePlayBGM(params object[] data)
		{
		}

		// Token: 0x0600B993 RID: 47507 RVA: 0x00034E18 File Offset: 0x00033018
		[Token(Token = "0x600B993")]
		[Address(RVA = "0x15B2B6C", Offset = "0x15B2B6C", VA = "0x7BBBDB2B6C")]
		public bool IsAvatarWindowCreated()
		{
			return default(bool);
		}

		// Token: 0x0600B994 RID: 47508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B994")]
		[Address(RVA = "0x15B2690", Offset = "0x15B2690", VA = "0x7BBBDB2690")]
		private void PushCDNBgStack(AdType type)
		{
		}

		// Token: 0x0600B995 RID: 47509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B995")]
		[Address(RVA = "0x15B2734", Offset = "0x15B2734", VA = "0x7BBBDB2734")]
		private void PopCDNBgStack(AdType type, bool needShow = false)
		{
		}

		// Token: 0x0600B996 RID: 47510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B996")]
		[Address(RVA = "0x15B2BDC", Offset = "0x15B2BDC", VA = "0x7BBBDB2BDC")]
		private void OnAvatarInitReady(object[] data)
		{
		}

		// Token: 0x0600B997 RID: 47511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B997")]
		[Address(RVA = "0x15B2C18", Offset = "0x15B2C18", VA = "0x7BBBDB2C18")]
		private void OnEpCardActive(params object[] data)
		{
		}

		// Token: 0x0600B998 RID: 47512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B998")]
		[Address(RVA = "0x15B2CD4", Offset = "0x15B2CD4", VA = "0x7BBBDB2CD4")]
		private void OpenInstallmentRepayWnd(params object[] data)
		{
		}

		// Token: 0x0600B999 RID: 47513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B999")]
		[Address(RVA = "0x15B2E68", Offset = "0x15B2E68", VA = "0x7BBBDB2E68")]
		private void OnLobby2DObjectVisibleChange(params object[] data)
		{
		}

		// Token: 0x0600B99A RID: 47514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B99A")]
		[Address(RVA = "0x15B3030", Offset = "0x15B3030", VA = "0x7BBBDB3030")]
		public void InitBackground2D()
		{
		}

		// Token: 0x0600B99B RID: 47515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B99B")]
		[Address(RVA = "0x15AD0E0", Offset = "0x15AD0E0", VA = "0x7BBBDAD0E0")]
		private void LoadBackground2DObjects(ResourceID spineBGResID)
		{
		}

		// Token: 0x0600B99C RID: 47516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B99C")]
		[Address(RVA = "0x15B3154", Offset = "0x15B3154", VA = "0x7BBBDB3154")]
		private void OnHudNormalSettingChanged(params object[] data)
		{
		}

		// Token: 0x0600B99D RID: 47517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B99D")]
		[Address(RVA = "0x15B31CC", Offset = "0x15B31CC", VA = "0x7BBBDB31CC")]
		private void OnOpenReplay(params object[] data)
		{
		}

		// Token: 0x0600B99E RID: 47518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B99E")]
		[Address(RVA = "0x15B3304", Offset = "0x15B3304", VA = "0x7BBBDB3304")]
		private void OnChampionshipMatchEnd(params object[] data)
		{
		}

		// Token: 0x0600B99F RID: 47519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B99F")]
		[Address(RVA = "0x15B3438", Offset = "0x15B3438", VA = "0x7BBBDB3438")]
		private void OnShowLevelUpWindow(params object[] data)
		{
		}

		// Token: 0x0600B9A0 RID: 47520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9A0")]
		[Address(RVA = "0x15B35F4", Offset = "0x15B35F4", VA = "0x7BBBDB35F4")]
		private void OnEPLevelProcessUpdate(params object[] data)
		{
		}

		// Token: 0x0600B9A1 RID: 47521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9A1")]
		[Address(RVA = "0x15B37C8", Offset = "0x15B37C8", VA = "0x7BBBDB37C8")]
		public void SetOverMaskShow(bool isShow)
		{
		}

		// Token: 0x0600B9A2 RID: 47522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9A2")]
		[Address(RVA = "0x15B38B4", Offset = "0x15B38B4", VA = "0x7BBBDB38B4")]
		private void RefreshLoadingBg(uint mapID, uint groupMode, uint matchMode, uint GameMode)
		{
		}

		// Token: 0x0600B9A3 RID: 47523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9A3")]
		[Address(RVA = "0x15B3CE8", Offset = "0x15B3CE8", VA = "0x7BBBDB3CE8")]
		public void OnEPUnlock(params object[] data)
		{
		}

		// Token: 0x0600B9A4 RID: 47524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9A4")]
		[Address(RVA = "0x15B3ED0", Offset = "0x15B3ED0", VA = "0x7BBBDB3ED0")]
		private void ShowChampionshipEmulatorErrorWnd(params object[] data)
		{
		}

		// Token: 0x0600B9A5 RID: 47525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9A5")]
		[Address(RVA = "0x15B4030", Offset = "0x15B4030", VA = "0x7BBBDB4030")]
		private void ShowCommonFeature(params object[] data)
		{
		}

		// Token: 0x0600B9A6 RID: 47526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9A6")]
		[Address(RVA = "0x15B4128", Offset = "0x15B4128", VA = "0x7BBBDB4128")]
		private void ShowFullScreenPreview(params object[] data)
		{
		}

		// Token: 0x0600B9A7 RID: 47527 RVA: 0x00034E30 File Offset: 0x00033030
		[Token(Token = "0x600B9A7")]
		[Address(RVA = "0x15B4288", Offset = "0x15B4288", VA = "0x7BBBDB4288")]
		public bool IsPortraitShow()
		{
			return default(bool);
		}

		// Token: 0x0600B9A8 RID: 47528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9A8")]
		[Address(RVA = "0x15B4350", Offset = "0x15B4350", VA = "0x7BBBDB4350")]
		private void ShowDebugBtn(params object[] param)
		{
		}

		// Token: 0x0600B9A9 RID: 47529 RVA: 0x00034E48 File Offset: 0x00033048
		[Token(Token = "0x600B9A9")]
		[Address(RVA = "0x15B46E4", Offset = "0x15B46E4", VA = "0x7BBBDB46E4")]
		public bool DebugBtnState()
		{
			return default(bool);
		}

		// Token: 0x0600B9AA RID: 47530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9AA")]
		[Address(RVA = "0x15B4784", Offset = "0x15B4784", VA = "0x7BBBDB4784")]
		private void OnInvitationTipsClose(params object[] data)
		{
		}

		// Token: 0x0600B9AB RID: 47531 RVA: 0x00034E60 File Offset: 0x00033060
		[Token(Token = "0x600B9AB")]
		[Address(RVA = "0x15B2F38", Offset = "0x15B2F38", VA = "0x7BBBDB2F38")]
		private bool NeedHide2DObjectNavigation()
		{
			return default(bool);
		}

		// Token: 0x0600B9AC RID: 47532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9AC")]
		[Address(RVA = "0x15B478C", Offset = "0x15B478C", VA = "0x7BBBDB478C")]
		public UIFrontEndScene()
		{
		}

		// Token: 0x0600B9AE RID: 47534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9AE")]
		[Address(RVA = "0x15B525C", Offset = "0x15B525C", VA = "0x7BBBDB525C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147AD0", Offset = "0x1147AD0")]
		private void <OnLastBattleTimeOut>b__78_0()
		{
		}

		// Token: 0x0600B9AF RID: 47535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9AF")]
		[Address(RVA = "0x15B5260", Offset = "0x15B5260", VA = "0x7BBBDB5260")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147AE0", Offset = "0x1147AE0")]
		private void <OnLastBattleTimeOut>b__78_1()
		{
		}

		// Token: 0x0600B9B0 RID: 47536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9B0")]
		[Address(RVA = "0x15B5264", Offset = "0x15B5264", VA = "0x7BBBDB5264")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147AF0", Offset = "0x1147AF0")]
		private void <OnStartMatchMaking>b__90_0()
		{
		}

		// Token: 0x0600B9B1 RID: 47537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9B1")]
		[Address(RVA = "0x15B5314", Offset = "0x15B5314", VA = "0x7BBBDB5314")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147B00", Offset = "0x1147B00")]
		private void <OnStartMatchMaking>b__90_1()
		{
		}

		// Token: 0x0600B9B2 RID: 47538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9B2")]
		[Address(RVA = "0x15B53BC", Offset = "0x15B53BC", VA = "0x7BBBDB53BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147B10", Offset = "0x1147B10")]
		private void <OnGroupStartNtf>b__96_0()
		{
		}

		// Token: 0x0600B9B3 RID: 47539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9B3")]
		[Address(RVA = "0x15B54EC", Offset = "0x15B54EC", VA = "0x7BBBDB54EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147B20", Offset = "0x1147B20")]
		private void <OnGroupStartNtf>b__96_1()
		{
		}

		// Token: 0x0600B9B4 RID: 47540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9B4")]
		[Address(RVA = "0x15B5614", Offset = "0x15B5614", VA = "0x7BBBDB5614")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147B30", Offset = "0x1147B30")]
		private void <SetCDNBackgroundByURL>b__129_0()
		{
		}

		// Token: 0x0400BB3B RID: 47931
		[Token(Token = "0x400BB3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform OverMaskPanel;

		// Token: 0x0400BB3C RID: 47932
		[Token(Token = "0x400BB3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform OverMaskTexture;

		// Token: 0x0400BB3D RID: 47933
		[Token(Token = "0x400BB3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform UIBGRoot;

		// Token: 0x0400BB3E RID: 47934
		[Token(Token = "0x400BB3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UITexture BgTexture;

		// Token: 0x0400BB3F RID: 47935
		[Token(Token = "0x400BB3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UISprite BgDarkMask;

		// Token: 0x0400BB40 RID: 47936
		[Token(Token = "0x400BB40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UITexture BgCDNTexture;

		// Token: 0x0400BB41 RID: 47937
		[Token(Token = "0x400BB41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UITexture BgTemplateTex;

		// Token: 0x0400BB42 RID: 47938
		[Token(Token = "0x400BB42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Transform Bg2DObjects;

		// Token: 0x0400BB43 RID: 47939
		[Token(Token = "0x400BB43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UI3DObjectHelper UI3DRootHelper;

		// Token: 0x0400BB44 RID: 47940
		[Token(Token = "0x400BB44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Camera UI3DCamera;

		// Token: 0x0400BB45 RID: 47941
		[Token(Token = "0x400BB45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Camera BgCamera;

		// Token: 0x0400BB46 RID: 47942
		[Token(Token = "0x400BB46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public UIPopupMessageBoxController m_MessageBox;

		// Token: 0x0400BB47 RID: 47943
		[Token(Token = "0x400BB47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private UICommonPopMenuController m_PopMenuController;

		// Token: 0x0400BB48 RID: 47944
		[Token(Token = "0x400BB48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private UICommonTipsController m_TipsController;

		// Token: 0x0400BB49 RID: 47945
		[Token(Token = "0x400BB49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private UIAvatarWindowController m_AvatarWindowController;

		// Token: 0x0400BB4A RID: 47946
		[Token(Token = "0x400BB4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private UIGameModeMainController m_GameModeMainController;

		// Token: 0x0400BB4B RID: 47947
		[Token(Token = "0x400BB4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private UIInvitationTipsBoxController m_CurInviteTipsController;

		// Token: 0x0400BB4C RID: 47948
		[Token(Token = "0x400BB4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private uint mDelayShowReconnect;

		// Token: 0x0400BB4D RID: 47949
		[Token(Token = "0x400BB4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private GameObject m_SpecificOverMask;

		// Token: 0x0400BB4E RID: 47950
		[Token(Token = "0x400BB4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private ResourceID m_bgUsedResID;

		// Token: 0x0400BB4F RID: 47951
		[Token(Token = "0x400BB4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private ResourceID m_LobbyBGSpine1;

		// Token: 0x0400BB50 RID: 47952
		[Token(Token = "0x400BB50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private ResourceID m_LobbyBGSpine2;

		// Token: 0x0400BB51 RID: 47953
		[Token(Token = "0x400BB51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private GameObject m_LobbyBG;

		// Token: 0x0400BB52 RID: 47954
		[Token(Token = "0x400BB52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private ResourceID m_CurrentSpineBGResID;

		// Token: 0x0400BB53 RID: 47955
		[Token(Token = "0x400BB53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private UIModelClan m_ModelClan;

		// Token: 0x0400BB54 RID: 47956
		[Token(Token = "0x400BB54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private UIModelInvitation m_ModelInvitation;

		// Token: 0x0400BB55 RID: 47957
		[Token(Token = "0x400BB55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Dictionary<EFrontendBGType, ResourceID> m_DictBgPath;

		// Token: 0x0400BB56 RID: 47958
		[Token(Token = "0x400BB56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Stack<EFrontendBGType> m_BgStack;

		// Token: 0x0400BB57 RID: 47959
		[Token(Token = "0x400BB57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Stack<AdType> m_CDNBgStack;

		// Token: 0x0400BB58 RID: 47960
		[Token(Token = "0x400BB58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Dictionary<EFrontendBGMType, ResourceID> m_DictBGMPath;

		// Token: 0x0400BB59 RID: 47961
		[Token(Token = "0x400BB59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private EFrontendBGMType m_CurrentBGMType;

		// Token: 0x0400BB5A RID: 47962
		[Token(Token = "0x400BB5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private List<EFrontendBGMType> m_NeedContinusPlayBGMLst;

		// Token: 0x0400BB5B RID: 47963
		[Token(Token = "0x400BB5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private UIDebugConsoleCommandItem DebugBtnCtrl;

		// Token: 0x0400BB5C RID: 47964
		[Token(Token = "0x400BB5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint _DelayCallId_ProcessOpenedByUrl;

		// Token: 0x0400BB5D RID: 47965
		[Token(Token = "0x400BB5D")]
		private const float _Delay_ProcessOpenedByUrl = 0.5f;

		// Token: 0x0400BB5E RID: 47966
		[Token(Token = "0x400BB5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private UIPopupMessageBoxController m_DownloadConfirmWindow;

		// Token: 0x0400BB5F RID: 47967
		[Token(Token = "0x400BB5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private UIMatchMakingWatingController m_MatchmakingWaiting;

		// Token: 0x0400BB60 RID: 47968
		[Token(Token = "0x400BB60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private UIMatchMakingWaitingOptimizedController m_MatchmakingWaitingOptimized;

		// Token: 0x0400BB61 RID: 47969
		[Token(Token = "0x400BB61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private uint m_AutoMatchGroupingTime;

		// Token: 0x0400BB62 RID: 47970
		[Token(Token = "0x400BB62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private uint m_AutoMatchMakingTime;

		// Token: 0x02002077 RID: 8311
		[Token(Token = "0x2002077")]
		public static class BatteryWatcher
		{
			// Token: 0x17000CBD RID: 3261
			// (get) Token: 0x0600B9B5 RID: 47541 RVA: 0x00034E78 File Offset: 0x00033078
			[Token(Token = "0x17000CBD")]
			public static bool IsBatteryCharging
			{
				[Token(Token = "0x600B9B5")]
				[Address(RVA = "0x214D5E0", Offset = "0x214D5E0", VA = "0x7BBC94D5E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000CBE RID: 3262
			// (get) Token: 0x0600B9B6 RID: 47542 RVA: 0x00034E90 File Offset: 0x00033090
			[Token(Token = "0x17000CBE")]
			public static float BatteryLevel
			{
				[Token(Token = "0x600B9B6")]
				[Address(RVA = "0x214D694", Offset = "0x214D694", VA = "0x7BBC94D694")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600B9B7 RID: 47543 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9B7")]
			[Address(RVA = "0x214D730", Offset = "0x214D730", VA = "0x7BBC94D730")]
			internal static void Begin()
			{
			}

			// Token: 0x0600B9B8 RID: 47544 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9B8")]
			[Address(RVA = "0x214D8C4", Offset = "0x214D8C4", VA = "0x7BBC94D8C4")]
			internal static void End()
			{
			}

			// Token: 0x0600B9B9 RID: 47545 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9B9")]
			[Address(RVA = "0x214D928", Offset = "0x214D928", VA = "0x7BBC94D928")]
			public static void OnBatteryChanged(bool charging, float batteryLevel)
			{
			}

			// Token: 0x0600B9BA RID: 47546 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9BA")]
			[Address(RVA = "0x214DB40", Offset = "0x214DB40", VA = "0x7BBC94DB40")]
			private static void OnBatteryChargingChanged(bool charging)
			{
			}

			// Token: 0x0600B9BB RID: 47547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9BB")]
			[Address(RVA = "0x214DCA4", Offset = "0x214DCA4", VA = "0x7BBC94DCA4")]
			private static void OnBatteryLevelChanged(float batteryLevel)
			{
			}

			// Token: 0x0400BB63 RID: 47971
			[Token(Token = "0x400BB63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static bool? _IsBatteryCharging;

			// Token: 0x0400BB64 RID: 47972
			[Token(Token = "0x400BB64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private static float _BatteryLevel;

			// Token: 0x0400BB65 RID: 47973
			[Token(Token = "0x400BB65")]
			private const float BATTERY_LEVEL_UPDATE_THRESHOLD = 0.05f;
		}

		// Token: 0x02002078 RID: 8312
		[Token(Token = "0x2002078")]
		private enum EInviteTipsType
		{
			// Token: 0x0400BB67 RID: 47975
			[Token(Token = "0x400BB67")]
			None,
			// Token: 0x0400BB68 RID: 47976
			[Token(Token = "0x400BB68")]
			GroupInvite,
			// Token: 0x0400BB69 RID: 47977
			[Token(Token = "0x400BB69")]
			Friend,
			// Token: 0x0400BB6A RID: 47978
			[Token(Token = "0x400BB6A")]
			JoinGroupRequest
		}

		// Token: 0x02002079 RID: 8313
		[Token(Token = "0x2002079")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD9E4", Offset = "0x10FD9E4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B9BE RID: 47550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9BE")]
			[Address(RVA = "0x214CCB0", Offset = "0x214CCB0", VA = "0x7BBC94CCB0")]
			public <>c()
			{
			}

			// Token: 0x0600B9BF RID: 47551 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9BF")]
			[Address(RVA = "0x214CCB8", Offset = "0x214CCB8", VA = "0x7BBC94CCB8")]
			internal void <ProcessOpenedByUrl>b__44_0()
			{
			}

			// Token: 0x0600B9C0 RID: 47552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9C0")]
			[Address(RVA = "0x214CD7C", Offset = "0x214CD7C", VA = "0x7BBC94CD7C")]
			internal void <ShowDebugBtn>b__186_0(string cmd)
			{
			}

			// Token: 0x0400BB6B RID: 47979
			[Token(Token = "0x400BB6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIFrontEndScene.<>c <>9;

			// Token: 0x0400BB6C RID: 47980
			[Token(Token = "0x400BB6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__44_0;

			// Token: 0x0400BB6D RID: 47981
			[Token(Token = "0x400BB6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static UIDebugConsoleCommandItem.OnRunCmd <>9__186_0;
		}

		// Token: 0x0200207A RID: 8314
		[Token(Token = "0x200207A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD9F4", Offset = "0x10FD9F4")]
		private sealed class <>c__DisplayClass63_0
		{
			// Token: 0x0600B9C1 RID: 47553 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9C1")]
			[Address(RVA = "0x214CE38", Offset = "0x214CE38", VA = "0x7BBC94CE38")]
			public <>c__DisplayClass63_0()
			{
			}

			// Token: 0x0400BB6E RID: 47982
			[Token(Token = "0x400BB6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelOptionalDownload model;

			// Token: 0x0400BB6F RID: 47983
			[Token(Token = "0x400BB6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object[] data;
		}

		// Token: 0x0200207B RID: 8315
		[Token(Token = "0x200207B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDA04", Offset = "0x10FDA04")]
		private sealed class <>c__DisplayClass63_1
		{
			// Token: 0x0600B9C2 RID: 47554 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9C2")]
			[Address(RVA = "0x214CE40", Offset = "0x214CE40", VA = "0x7BBC94CE40")]
			public <>c__DisplayClass63_1()
			{
			}

			// Token: 0x0600B9C3 RID: 47555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9C3")]
			[Address(RVA = "0x214CE48", Offset = "0x214CE48", VA = "0x7BBC94CE48")]
			internal void <OnShowDownloadPopup>b__0()
			{
			}

			// Token: 0x0600B9C4 RID: 47556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9C4")]
			[Address(RVA = "0x214D29C", Offset = "0x214D29C", VA = "0x7BBC94D29C")]
			internal void <OnShowDownloadPopup>b__1()
			{
			}

			// Token: 0x0400BB70 RID: 47984
			[Token(Token = "0x400BB70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ResourceID[] id_list;

			// Token: 0x0400BB71 RID: 47985
			[Token(Token = "0x400BB71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIFrontEndScene.<>c__DisplayClass63_0 CS$<>8__locals1;

			// Token: 0x0400BB72 RID: 47986
			[Token(Token = "0x400BB72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action <>9__1;
		}

		// Token: 0x0200207C RID: 8316
		[Token(Token = "0x200207C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDA14", Offset = "0x10FDA14")]
		private sealed class <>c__DisplayClass65_0
		{
			// Token: 0x0600B9C5 RID: 47557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9C5")]
			[Address(RVA = "0x214D4D8", Offset = "0x214D4D8", VA = "0x7BBC94D4D8")]
			public <>c__DisplayClass65_0()
			{
			}

			// Token: 0x0600B9C6 RID: 47558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9C6")]
			[Address(RVA = "0x214D4E0", Offset = "0x214D4E0", VA = "0x7BBC94D4E0")]
			internal void <OnShowDownloadConfirmPopup>b__1()
			{
			}

			// Token: 0x0400BB73 RID: 47987
			[Token(Token = "0x400BB73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelOptionalDownload model;

			// Token: 0x0400BB74 RID: 47988
			[Token(Token = "0x400BB74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIFrontEndScene <>4__this;
		}

		// Token: 0x0200207D RID: 8317
		[Token(Token = "0x200207D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDA24", Offset = "0x10FDA24")]
		private sealed class <>c__DisplayClass65_1
		{
			// Token: 0x0600B9C7 RID: 47559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9C7")]
			[Address(RVA = "0x214D50C", Offset = "0x214D50C", VA = "0x7BBC94D50C")]
			public <>c__DisplayClass65_1()
			{
			}

			// Token: 0x0600B9C8 RID: 47560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9C8")]
			[Address(RVA = "0x214D514", Offset = "0x214D514", VA = "0x7BBC94D514")]
			internal void <OnShowDownloadConfirmPopup>b__0()
			{
			}

			// Token: 0x0400BB75 RID: 47989
			[Token(Token = "0x400BB75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ResourceID[] id_list;

			// Token: 0x0400BB76 RID: 47990
			[Token(Token = "0x400BB76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIFrontEndScene.<>c__DisplayClass65_0 CS$<>8__locals1;
		}

		// Token: 0x0200207E RID: 8318
		[Token(Token = "0x200207E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDA34", Offset = "0x10FDA34")]
		private sealed class <>c__DisplayClass150_0
		{
			// Token: 0x0600B9C9 RID: 47561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9C9")]
			[Address(RVA = "0x214CE1C", Offset = "0x214CE1C", VA = "0x7BBC94CE1C")]
			public <>c__DisplayClass150_0()
			{
			}

			// Token: 0x0600B9CA RID: 47562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9CA")]
			[Address(RVA = "0x214CE24", Offset = "0x214CE24", VA = "0x7BBC94CE24")]
			internal void <ShowGroupMessageBox>b__0()
			{
			}

			// Token: 0x0400BB77 RID: 47991
			[Token(Token = "0x400BB77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action cb;
		}
	}
}
