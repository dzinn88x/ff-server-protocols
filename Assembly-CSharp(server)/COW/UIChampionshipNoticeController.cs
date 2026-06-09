using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001484 RID: 5252
	[Token(Token = "0x2001484")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECFE4", Offset = "0x10ECFE4")]
	public class UIChampionshipNoticeController : UIPopupWindowController
	{
		// Token: 0x060058A9 RID: 22697 RVA: 0x0001A208 File Offset: 0x00018408
		[Token(Token = "0x60058A9")]
		[Address(RVA = "0x1EC6FC4", Offset = "0x1EC6FC4", VA = "0x7BBC6C6FC4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060058AA RID: 22698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058AA")]
		[Address(RVA = "0x1EC7014", Offset = "0x1EC7014", VA = "0x7BBC6C7014", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058AB")]
		[Address(RVA = "0x1EC71F8", Offset = "0x1EC71F8", VA = "0x7BBC6C71F8", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060058AC RID: 22700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058AC")]
		[Address(RVA = "0x1EC7200", Offset = "0x1EC7200", VA = "0x7BBC6C7200", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058AD")]
		[Address(RVA = "0x1EC722C", Offset = "0x1EC722C", VA = "0x7BBC6C722C")]
		public void SetData(uint championshipType, uint championhipID)
		{
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058AE")]
		[Address(RVA = "0x1EC7400", Offset = "0x1EC7400", VA = "0x7BBC6C7400")]
		private void SetCDNUrlList(string url)
		{
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058AF")]
		[Address(RVA = "0x1EC7490", Offset = "0x1EC7490", VA = "0x7BBC6C7490")]
		private void SetGoPosList(uint goPos)
		{
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B0")]
		[Address(RVA = "0x1EC7500", Offset = "0x1EC7500", VA = "0x7BBC6C7500")]
		private void RefreshView()
		{
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B1")]
		[Address(RVA = "0x1EC7980", Offset = "0x1EC7980", VA = "0x7BBC6C7980")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113F320", Offset = "0x113F320")]
		private IEnumerator AutoScrollItem()
		{
			return null;
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B2")]
		[Address(RVA = "0x1EC7A20", Offset = "0x1EC7A20", VA = "0x7BBC6C7A20")]
		private void OnAutoScrollAdItem(int next = 1)
		{
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B3")]
		[Address(RVA = "0x1EC7BB0", Offset = "0x1EC7BB0", VA = "0x7BBC6C7BB0")]
		private void OnLeftBtnClick()
		{
		}

		// Token: 0x060058B4 RID: 22708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B4")]
		[Address(RVA = "0x1EC7BB8", Offset = "0x1EC7BB8", VA = "0x7BBC6C7BB8")]
		private void OnRightBtnClick()
		{
		}

		// Token: 0x060058B5 RID: 22709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B5")]
		[Address(RVA = "0x1EC7BC0", Offset = "0x1EC7BC0", VA = "0x7BBC6C7BC0")]
		private void GetCenterItem(GameObject centeredObject)
		{
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B6")]
		[Address(RVA = "0x1EC7D90", Offset = "0x1EC7D90", VA = "0x7BBC6C7D90")]
		public UIChampionshipNoticeController()
		{
		}

		// Token: 0x04007C75 RID: 31861
		[Token(Token = "0x4007C75")]
		[FieldOffset(Offset = "0x98")]
		private UIChampionshipNoticePopupView m_View;

		// Token: 0x04007C76 RID: 31862
		[Token(Token = "0x4007C76")]
		[FieldOffset(Offset = "0xA0")]
		private ChampionshipSettingDesc m_SettingInfo;

		// Token: 0x04007C77 RID: 31863
		[Token(Token = "0x4007C77")]
		[FieldOffset(Offset = "0xA8")]
		private List<string> m_CDNUrlList;

		// Token: 0x04007C78 RID: 31864
		[Token(Token = "0x4007C78")]
		[FieldOffset(Offset = "0xB0")]
		private List<uint> m_GoPosList;

		// Token: 0x04007C79 RID: 31865
		[Token(Token = "0x4007C79")]
		[FieldOffset(Offset = "0xB8")]
		private int m_selectedIndex;

		// Token: 0x04007C7A RID: 31866
		[Token(Token = "0x4007C7A")]
		[FieldOffset(Offset = "0xC0")]
		private List<UIChampionshipNoticeDotController> m_DotCtrls;

		// Token: 0x04007C7B RID: 31867
		[Token(Token = "0x4007C7B")]
		[FieldOffset(Offset = "0xC8")]
		private List<UIChampionshipNoticeItemController> m_NetworkTextures;

		// Token: 0x02001485 RID: 5253
		[Token(Token = "0x2001485")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ED01C", Offset = "0x10ED01C")]
		private sealed class <AutoScrollItem>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060058B7 RID: 22711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058B7")]
			[Address(RVA = "0x1EC79F4", Offset = "0x1EC79F4", VA = "0x7BBC6C79F4")]
			[DebuggerHidden]
			public <AutoScrollItem>d__15(int <>1__state)
			{
			}

			// Token: 0x060058B8 RID: 22712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058B8")]
			[Address(RVA = "0x1EC7E80", Offset = "0x1EC7E80", VA = "0x7BBC6C7E80", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060058B9 RID: 22713 RVA: 0x0001A220 File Offset: 0x00018420
			[Token(Token = "0x60058B9")]
			[Address(RVA = "0x1EC7E84", Offset = "0x1EC7E84", VA = "0x7BBC6C7E84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700089D RID: 2205
			// (get) Token: 0x060058BA RID: 22714 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700089D")]
			private object Current
			{
				[Token(Token = "0x60058BA")]
				[Address(RVA = "0x1EC7F38", Offset = "0x1EC7F38", VA = "0x7BBC6C7F38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060058BB RID: 22715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60058BB")]
			[Address(RVA = "0x1EC7F40", Offset = "0x1EC7F40", VA = "0x7BBC6C7F40", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700089E RID: 2206
			// (get) Token: 0x060058BC RID: 22716 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700089E")]
			private object Current
			{
				[Token(Token = "0x60058BC")]
				[Address(RVA = "0x1EC7FA8", Offset = "0x1EC7FA8", VA = "0x7BBC6C7FA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007C7C RID: 31868
			[Token(Token = "0x4007C7C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007C7D RID: 31869
			[Token(Token = "0x4007C7D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007C7E RID: 31870
			[Token(Token = "0x4007C7E")]
			[FieldOffset(Offset = "0x20")]
			public UIChampionshipNoticeController <>4__this;
		}
	}
}
