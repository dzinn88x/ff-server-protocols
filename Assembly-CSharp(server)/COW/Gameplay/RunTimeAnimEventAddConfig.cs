using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay
{
	// Token: 0x0200269D RID: 9885
	[Token(Token = "0x200269D")]
	public class RunTimeAnimEventAddConfig : MonoBehaviour
	{
		// Token: 0x0600CCB9 RID: 52409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCB9")]
		[Address(RVA = "0x1D8BF9C", Offset = "0x1D8BF9C", VA = "0x7BBC58BF9C")]
		public Dictionary<uint, bool> InitConfigEvents(Dictionary<uint, bool> addedConfigs, uint configUID)
		{
			return null;
		}

		// Token: 0x0600CCBA RID: 52410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCBA")]
		[Address(RVA = "0x1D8C078", Offset = "0x1D8C078", VA = "0x7BBC58C078")]
		public void AddEventsToClip()
		{
		}

		// Token: 0x0600CCBB RID: 52411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCBB")]
		[Address(RVA = "0x1D8C6D0", Offset = "0x1D8C6D0", VA = "0x7BBC58C6D0")]
		private string GetFunctionNameByType(AnimEventType type, string functionName)
		{
			return null;
		}

		// Token: 0x0600CCBC RID: 52412 RVA: 0x00036E28 File Offset: 0x00035028
		[Token(Token = "0x600CCBC")]
		[Address(RVA = "0x1D8C77C", Offset = "0x1D8C77C", VA = "0x7BBC58C77C")]
		private uint GetResourceIDFromString(string strResID)
		{
			return 0U;
		}

		// Token: 0x0600CCBD RID: 52413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCBD")]
		[Address(RVA = "0x1D8C88C", Offset = "0x1D8C88C", VA = "0x7BBC58C88C")]
		public RunTimeAnimEventAddConfig()
		{
		}

		// Token: 0x0401008B RID: 65675
		[Token(Token = "0x401008B")]
		[FieldOffset(Offset = "0x18")]
		public bool m_IsPlayFootSoundByEvent;

		// Token: 0x0401008C RID: 65676
		[Token(Token = "0x401008C")]
		[FieldOffset(Offset = "0x20")]
		public List<ClipEvents> m_ListClipEvents;

		// Token: 0x0401008D RID: 65677
		[Token(Token = "0x401008D")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, bool> m_AddedClipNameMap;
	}
}
