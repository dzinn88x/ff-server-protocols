using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A81 RID: 6785
	[Token(Token = "0x2001A81")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8594", Offset = "0x10F8594")]
	public class UINavigationController : UIBaseNavigationController
	{
		// Token: 0x06008EF5 RID: 36597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EF5")]
		[Address(RVA = "0x14D7D5C", Offset = "0x14D7D5C", VA = "0x7BBBCD7D5C", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06008EF6 RID: 36598 RVA: 0x000261D8 File Offset: 0x000243D8
		[Token(Token = "0x170009E8")]
		public new bool IsRoot
		{
			[Token(Token = "0x6008EF6")]
			[Address(RVA = "0x14D81E0", Offset = "0x14D81E0", VA = "0x7BBBCD81E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06008EF7 RID: 36599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EF7")]
		[Address(RVA = "0x14D81E8", Offset = "0x14D81E8", VA = "0x7BBBCD81E8")]
		protected void SetCornerGroups(bool status)
		{
		}

		// Token: 0x06008EF8 RID: 36600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EF8")]
		[Address(RVA = "0x14D8450", Offset = "0x14D8450", VA = "0x7BBBCD8450")]
		protected void SetChatBtn(bool status)
		{
		}

		// Token: 0x06008EF9 RID: 36601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008EF9")]
		[Address(RVA = "0x14D8518", Offset = "0x14D8518", VA = "0x7BBBCD8518")]
		public UIBaseController GetTopButtonGroup()
		{
			return null;
		}

		// Token: 0x06008EFA RID: 36602 RVA: 0x000261F0 File Offset: 0x000243F0
		[Token(Token = "0x6008EFA")]
		[Address(RVA = "0x14D8520", Offset = "0x14D8520", VA = "0x7BBBCD8520")]
		public Vector3 GetNaviTitleLeftPos()
		{
			return default(Vector3);
		}

		// Token: 0x06008EFB RID: 36603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008EFB")]
		[Address(RVA = "0x14D85E0", Offset = "0x14D85E0", VA = "0x7BBBCD85E0")]
		public Transform GetNaviCustomizedCtrlTrans()
		{
			return null;
		}

		// Token: 0x06008EFC RID: 36604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EFC")]
		[Address(RVA = "0x14CE558", Offset = "0x14CE558", VA = "0x7BBBCCE558", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06008EFD RID: 36605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EFD")]
		[Address(RVA = "0x14D86E4", Offset = "0x14D86E4", VA = "0x7BBBCD86E4", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06008EFE RID: 36606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EFE")]
		[Address(RVA = "0x14D8AE4", Offset = "0x14D8AE4", VA = "0x7BBBCD8AE4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008EFF RID: 36607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EFF")]
		[Address(RVA = "0x14D8C84", Offset = "0x14D8C84", VA = "0x7BBBCD8C84", Slot = "31")]
		protected virtual void OnSendShowTimeEvent(ref string eventLogKey, ref EventLogger.EventPageDetentionTime eventLog)
		{
		}

		// Token: 0x06008F00 RID: 36608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F00")]
		[Address(RVA = "0x14D8C88", Offset = "0x14D8C88", VA = "0x7BBBCD8C88")]
		protected void OnDataReady()
		{
		}

		// Token: 0x06008F01 RID: 36609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008F01")]
		[Address(RVA = "0x14D8684", Offset = "0x14D8684", VA = "0x7BBBCD8684")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11446E4", Offset = "0x11446E4")]
		private IEnumerator Lobby2DObjectsShow()
		{
			return null;
		}

		// Token: 0x06008F02 RID: 36610 RVA: 0x00026208 File Offset: 0x00024408
		[Token(Token = "0x6008F02")]
		[Address(RVA = "0x14D8CEC", Offset = "0x14D8CEC", VA = "0x7BBBCD8CEC", Slot = "32")]
		protected virtual bool NeedWaitDataReady()
		{
			return default(bool);
		}

		// Token: 0x06008F03 RID: 36611 RVA: 0x00026220 File Offset: 0x00024420
		[Token(Token = "0x6008F03")]
		[Address(RVA = "0x14D8CF4", Offset = "0x14D8CF4", VA = "0x7BBBCD8CF4", Slot = "33")]
		public virtual EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06008F04 RID: 36612 RVA: 0x00026238 File Offset: 0x00024438
		[Token(Token = "0x6008F04")]
		[Address(RVA = "0x14D8CFC", Offset = "0x14D8CFC", VA = "0x7BBBCD8CFC", Slot = "34")]
		public virtual AdType GetBackgroundCDNImageType()
		{
			return AdType.AdType_NONE;
		}

		// Token: 0x06008F05 RID: 36613 RVA: 0x00026250 File Offset: 0x00024450
		[Token(Token = "0x6008F05")]
		[Address(RVA = "0x14D8D04", Offset = "0x14D8D04", VA = "0x7BBBCD8D04", Slot = "35")]
		public virtual EFrontendBGMType GetBGMType()
		{
			return EFrontendBGMType.NONE;
		}

		// Token: 0x06008F06 RID: 36614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008F06")]
		[Address(RVA = "0x14D8D0C", Offset = "0x14D8D0C", VA = "0x7BBBCD8D0C", Slot = "36")]
		public virtual List<string> GetNeedShowUI3dObjectNames()
		{
			return null;
		}

		// Token: 0x06008F07 RID: 36615 RVA: 0x00026268 File Offset: 0x00024468
		[Token(Token = "0x6008F07")]
		[Address(RVA = "0x14D8D14", Offset = "0x14D8D14", VA = "0x7BBBCD8D14", Slot = "37")]
		public virtual bool OverwriteBackButtonLogic()
		{
			return default(bool);
		}

		// Token: 0x06008F08 RID: 36616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F08")]
		[Address(RVA = "0x14D8D1C", Offset = "0x14D8D1C", VA = "0x7BBBCD8D1C")]
		public void OnBackButtonClick(params object[] param)
		{
		}

		// Token: 0x06008F09 RID: 36617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F09")]
		[Address(RVA = "0x14D8DBC", Offset = "0x14D8DBC", VA = "0x7BBBCD8DBC", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x06008F0A RID: 36618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F0A")]
		[Address(RVA = "0x14D8DC0", Offset = "0x14D8DC0", VA = "0x7BBBCD8DC0")]
		protected void HideAllNavigation()
		{
		}

		// Token: 0x06008F0B RID: 36619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F0B")]
		[Address(RVA = "0x14D8ED0", Offset = "0x14D8ED0", VA = "0x7BBBCD8ED0")]
		protected void ShowAllNavigation()
		{
		}

		// Token: 0x06008F0C RID: 36620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F0C")]
		[Address(RVA = "0x14D8FE8", Offset = "0x14D8FE8", VA = "0x7BBBCD8FE8", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x06008F0D RID: 36621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F0D")]
		[Address(RVA = "0x14D8FEC", Offset = "0x14D8FEC", VA = "0x7BBBCD8FEC", Slot = "38")]
		protected virtual void OnHelpButtonClick(params object[] param)
		{
		}

		// Token: 0x06008F0E RID: 36622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F0E")]
		[Address(RVA = "0x14CF5F8", Offset = "0x14CF5F8", VA = "0x7BBBCCF5F8")]
		public void SetTopLeftBarState(bool value)
		{
		}

		// Token: 0x06008F0F RID: 36623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F0F")]
		[Address(RVA = "0x14D3064", Offset = "0x14D3064", VA = "0x7BBBCD3064")]
		public UINavigationController()
		{
		}

		// Token: 0x04009A71 RID: 39537
		[Token(Token = "0x4009A71")]
		[FieldOffset(Offset = "0x70")]
		public ulong m_StartShowTime;

		// Token: 0x04009A72 RID: 39538
		[Token(Token = "0x4009A72")]
		[FieldOffset(Offset = "0x78")]
		public int m_ShowTime;

		// Token: 0x04009A73 RID: 39539
		[Token(Token = "0x4009A73")]
		[FieldOffset(Offset = "0x80")]
		protected UILobbyProfileController m_Profile;

		// Token: 0x04009A74 RID: 39540
		[Token(Token = "0x4009A74")]
		[FieldOffset(Offset = "0x88")]
		private UILobbyCoinsController m_Coins;

		// Token: 0x04009A75 RID: 39541
		[Token(Token = "0x4009A75")]
		[FieldOffset(Offset = "0x90")]
		protected UITopButtonGroupController m_TopBtns;

		// Token: 0x04009A76 RID: 39542
		[Token(Token = "0x4009A76")]
		[FieldOffset(Offset = "0x98")]
		private UILobbyChatController m_ChatBtn;

		// Token: 0x04009A77 RID: 39543
		[Token(Token = "0x4009A77")]
		[FieldOffset(Offset = "0xA0")]
		private UILobbyOptionalDownloaderController m_OptionalDownload;

		// Token: 0x04009A78 RID: 39544
		[Token(Token = "0x4009A78")]
		[FieldOffset(Offset = "0xA8")]
		private bool showTopBar;

		// Token: 0x04009A79 RID: 39545
		[Token(Token = "0x4009A79")]
		[FieldOffset(Offset = "0xA9")]
		protected bool isDataInited;

		// Token: 0x02001A82 RID: 6786
		[Token(Token = "0x2001A82")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F85CC", Offset = "0x10F85CC")]
		private sealed class <Lobby2DObjectsShow>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008F10 RID: 36624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F10")]
			[Address(RVA = "0x14D8CC0", Offset = "0x14D8CC0", VA = "0x7BBBCD8CC0")]
			[DebuggerHidden]
			public <Lobby2DObjectsShow>d__22(int <>1__state)
			{
			}

			// Token: 0x06008F11 RID: 36625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F11")]
			[Address(RVA = "0x14D8FF0", Offset = "0x14D8FF0", VA = "0x7BBBCD8FF0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008F12 RID: 36626 RVA: 0x00026280 File Offset: 0x00024480
			[Token(Token = "0x6008F12")]
			[Address(RVA = "0x14D8FF4", Offset = "0x14D8FF4", VA = "0x7BBBCD8FF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009E9 RID: 2537
			// (get) Token: 0x06008F13 RID: 36627 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009E9")]
			private object Current
			{
				[Token(Token = "0x6008F13")]
				[Address(RVA = "0x14D9140", Offset = "0x14D9140", VA = "0x7BBBCD9140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008F14 RID: 36628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F14")]
			[Address(RVA = "0x14D9148", Offset = "0x14D9148", VA = "0x7BBBCD9148", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009EA RID: 2538
			// (get) Token: 0x06008F15 RID: 36629 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009EA")]
			private object Current
			{
				[Token(Token = "0x6008F15")]
				[Address(RVA = "0x14D91B0", Offset = "0x14D91B0", VA = "0x7BBBCD91B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009A7A RID: 39546
			[Token(Token = "0x4009A7A")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009A7B RID: 39547
			[Token(Token = "0x4009A7B")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;
		}
	}
}
