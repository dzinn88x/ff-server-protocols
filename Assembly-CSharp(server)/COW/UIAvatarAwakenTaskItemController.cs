using System;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001436 RID: 5174
	[Token(Token = "0x2001436")]
	public class UIAvatarAwakenTaskItemController : MonoBehaviour
	{
		// Token: 0x060055DC RID: 21980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DC")]
		[Address(RVA = "0x1B21788", Offset = "0x1B21788", VA = "0x7BBC321788")]
		private void Start()
		{
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DD")]
		[Address(RVA = "0x1B1C418", Offset = "0x1B1C418", VA = "0x7BBC31C418")]
		public void SetData(uint avatarID, AwakenTask taskData, int index)
		{
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x00019908 File Offset: 0x00017B08
		[Token(Token = "0x60055DE")]
		[Address(RVA = "0x1B1D3D4", Offset = "0x1B1D3D4", VA = "0x7BBC31D3D4")]
		public uint GetTaskID()
		{
			return 0U;
		}

		// Token: 0x060055DF RID: 21983 RVA: 0x00019920 File Offset: 0x00017B20
		[Token(Token = "0x60055DF")]
		[Address(RVA = "0x1B1D3DC", Offset = "0x1B1D3DC", VA = "0x7BBC31D3DC")]
		public int GetUIIndex()
		{
			return 0;
		}

		// Token: 0x060055E0 RID: 21984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E0")]
		[Address(RVA = "0x1B21A54", Offset = "0x1B21A54", VA = "0x7BBC321A54")]
		private void OnButtonClick()
		{
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E1")]
		[Address(RVA = "0x1B21894", Offset = "0x1B21894", VA = "0x7BBC321894")]
		private void UpdateButtonState(EProfile.TaskState state)
		{
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x00019938 File Offset: 0x00017B38
		[Token(Token = "0x60055E2")]
		[Address(RVA = "0x1B21878", Offset = "0x1B21878", VA = "0x7BBC321878")]
		private uint GetUnitRatio(uint val, bool needChangeVal)
		{
			return 0U;
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E3")]
		[Address(RVA = "0x1B21B38", Offset = "0x1B21B38", VA = "0x7BBC321B38")]
		public UIAvatarAwakenTaskItemController()
		{
		}

		// Token: 0x04007A9B RID: 31387
		[Token(Token = "0x4007A9B")]
		[FieldOffset(Offset = "0x18")]
		public UILabel Desc;

		// Token: 0x04007A9C RID: 31388
		[Token(Token = "0x4007A9C")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Process;

		// Token: 0x04007A9D RID: 31389
		[Token(Token = "0x4007A9D")]
		[FieldOffset(Offset = "0x28")]
		public Transform AwardItem;

		// Token: 0x04007A9E RID: 31390
		[Token(Token = "0x4007A9E")]
		[FieldOffset(Offset = "0x30")]
		public Transform AwardItem2;

		// Token: 0x04007A9F RID: 31391
		[Token(Token = "0x4007A9F")]
		[FieldOffset(Offset = "0x38")]
		public UIButton StateButton;

		// Token: 0x04007AA0 RID: 31392
		[Token(Token = "0x4007AA0")]
		[FieldOffset(Offset = "0x40")]
		public GameObject OperateAwarded;

		// Token: 0x04007AA1 RID: 31393
		[Token(Token = "0x4007AA1")]
		[FieldOffset(Offset = "0x48")]
		public GameObject OperateFinished;

		// Token: 0x04007AA2 RID: 31394
		[Token(Token = "0x4007AA2")]
		[FieldOffset(Offset = "0x50")]
		public GameObject OperateReceived;

		// Token: 0x04007AA3 RID: 31395
		[Token(Token = "0x4007AA3")]
		[FieldOffset(Offset = "0x58")]
		public UIWidget TaskWidget;

		// Token: 0x04007AA4 RID: 31396
		[Token(Token = "0x4007AA4")]
		[FieldOffset(Offset = "0x60")]
		public UIWidget AdjustWidget;

		// Token: 0x04007AA5 RID: 31397
		[Token(Token = "0x4007AA5")]
		[FieldOffset(Offset = "0x68")]
		private uint m_TaskID;

		// Token: 0x04007AA6 RID: 31398
		[Token(Token = "0x4007AA6")]
		[FieldOffset(Offset = "0x6C")]
		private int m_Index;

		// Token: 0x04007AA7 RID: 31399
		[Token(Token = "0x4007AA7")]
		[FieldOffset(Offset = "0x70")]
		private uint m_AvatarID;

		// Token: 0x04007AA8 RID: 31400
		[Token(Token = "0x4007AA8")]
		[FieldOffset(Offset = "0x78")]
		private UIModelAvatarProfile m_Model;

		// Token: 0x04007AA9 RID: 31401
		[Token(Token = "0x4007AA9")]
		[FieldOffset(Offset = "0x80")]
		private EProfile.TaskState m_State;

		// Token: 0x04007AAA RID: 31402
		[Token(Token = "0x4007AAA")]
		[FieldOffset(Offset = "0x88")]
		private UIStandardItemMiniController m_CacheAward1;

		// Token: 0x04007AAB RID: 31403
		[Token(Token = "0x4007AAB")]
		[FieldOffset(Offset = "0x90")]
		private UIStandardItemMiniController m_CacheAward2;
	}
}
