using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200152E RID: 5422
	[Token(Token = "0x200152E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE34C", Offset = "0x10EE34C")]
	public class UILadderMatchLobbyEntryController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06005D69 RID: 23913 RVA: 0x0001B1F8 File Offset: 0x000193F8
		[Token(Token = "0x6005D69")]
		[Address(RVA = "0x1E88DC0", Offset = "0x1E88DC0", VA = "0x7BBC688DC0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x0001B210 File Offset: 0x00019410
		[Token(Token = "0x6005D6A")]
		[Address(RVA = "0x1E88E10", Offset = "0x1E88E10", VA = "0x7BBC688E10", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D6B")]
		[Address(RVA = "0x1E88E74", Offset = "0x1E88E74", VA = "0x7BBC688E74", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D6C")]
		[Address(RVA = "0x1E89570", Offset = "0x1E89570", VA = "0x7BBC689570", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D6D")]
		[Address(RVA = "0x1E899E4", Offset = "0x1E899E4", VA = "0x7BBC6899E4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D6E")]
		[Address(RVA = "0x1E89AEC", Offset = "0x1E89AEC", VA = "0x7BBC689AEC")]
		private void CloseGuide()
		{
		}

		// Token: 0x06005D6F RID: 23919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D6F")]
		[Address(RVA = "0x1E89B84", Offset = "0x1E89B84", VA = "0x7BBC689B84")]
		private void OnEntryClick()
		{
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D70")]
		[Address(RVA = "0x1E890F4", Offset = "0x1E890F4", VA = "0x7BBC6890F4")]
		private void RefreshView()
		{
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D71")]
		[Address(RVA = "0x1E89E58", Offset = "0x1E89E58", VA = "0x7BBC689E58")]
		private void RefreshOpeningUI()
		{
		}

		// Token: 0x06005D72 RID: 23922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D72")]
		[Address(RVA = "0x1E8A074", Offset = "0x1E8A074", VA = "0x7BBC68A074")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113F924", Offset = "0x113F924")]
		private IEnumerator ShowRankingGuide()
		{
			return null;
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D73")]
		[Address(RVA = "0x1E8A114", Offset = "0x1E8A114", VA = "0x7BBC68A114")]
		public UILadderMatchLobbyEntryController()
		{
		}

		// Token: 0x04007F11 RID: 32529
		[Token(Token = "0x4007F11")]
		[FieldOffset(Offset = "0x58")]
		private LadderMatchLobbyEntryView m_View;

		// Token: 0x04007F12 RID: 32530
		[Token(Token = "0x4007F12")]
		[FieldOffset(Offset = "0x60")]
		private UIModelLadderMatch m_LadderModel;

		// Token: 0x04007F13 RID: 32531
		[Token(Token = "0x4007F13")]
		[FieldOffset(Offset = "0x68")]
		private UIModelInventory m_InventoryModel;

		// Token: 0x04007F14 RID: 32532
		[Token(Token = "0x4007F14")]
		[FieldOffset(Offset = "0x70")]
		private UICommonGuideController m_GuideCtrl;

		// Token: 0x04007F15 RID: 32533
		[Token(Token = "0x4007F15")]
		[FieldOffset(Offset = "0x78")]
		private UIModelUser m_ModelUser;

		// Token: 0x0200152F RID: 5423
		[Token(Token = "0x200152F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE384", Offset = "0x10EE384")]
		private sealed class <ShowRankingGuide>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005D74 RID: 23924 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D74")]
			[Address(RVA = "0x1E8A0E8", Offset = "0x1E8A0E8", VA = "0x7BBC68A0E8")]
			[DebuggerHidden]
			public <ShowRankingGuide>d__14(int <>1__state)
			{
			}

			// Token: 0x06005D75 RID: 23925 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D75")]
			[Address(RVA = "0x1E8A11C", Offset = "0x1E8A11C", VA = "0x7BBC68A11C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005D76 RID: 23926 RVA: 0x0001B228 File Offset: 0x00019428
			[Token(Token = "0x6005D76")]
			[Address(RVA = "0x1E8A120", Offset = "0x1E8A120", VA = "0x7BBC68A120", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008AE RID: 2222
			// (get) Token: 0x06005D77 RID: 23927 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008AE")]
			private object Current
			{
				[Token(Token = "0x6005D77")]
				[Address(RVA = "0x1E8A4EC", Offset = "0x1E8A4EC", VA = "0x7BBC68A4EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005D78 RID: 23928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D78")]
			[Address(RVA = "0x1E8A4F4", Offset = "0x1E8A4F4", VA = "0x7BBC68A4F4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008AF RID: 2223
			// (get) Token: 0x06005D79 RID: 23929 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008AF")]
			private object Current
			{
				[Token(Token = "0x6005D79")]
				[Address(RVA = "0x1E8A55C", Offset = "0x1E8A55C", VA = "0x7BBC68A55C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007F16 RID: 32534
			[Token(Token = "0x4007F16")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007F17 RID: 32535
			[Token(Token = "0x4007F17")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007F18 RID: 32536
			[Token(Token = "0x4007F18")]
			[FieldOffset(Offset = "0x20")]
			public UILadderMatchLobbyEntryController <>4__this;
		}
	}
}
